using Microsoft.AspNetCore.Mvc;
using TaskManager.Data;
using Microsoft.EntityFrameworkCore;

namespace TaskManager.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PessoasController : ControllerBase
    {
        private readonly AppDbContext _context;

        public PessoasController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Pessoa>>> GetPessoas()
        {
            return await _context.Pessoas.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Pessoa>> GetPessoa(int id)
        {
            var pessoa = await _context.Pessoas.FindAsync(id);

            if (pessoa == null)
            {
                return NotFound();
            }

            return pessoa;
        }

        [HttpPost]
        public async Task<ActionResult<Pessoa>> PostPessoa(Pessoa pessoa)
        {
            _context.Pessoas.Add(pessoa);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPessoa), new { id = pessoa.Id }, pessoa);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutPessoa(int id, Pessoa pessoa)
        {
            if (id != pessoa.Id)
            {
                return BadRequest();
            }

            _context.Entry(pessoa).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PessoaExists(id))
                {
                    return NotFound();
                }
                throw;
            }

            await AtualizarStatusPessoa(pessoa.Id);

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePessoa(int id)
        {
            var pessoa = await _context.Pessoas.Include(p => p.Tarefas).FirstOrDefaultAsync(p => p.Id == id);
            if (pessoa == null || pessoa.Tarefas.Any(t => !t.Concluida))
            {
                return BadRequest("Pessoa não pode ser excluída enquanto houver tarefas pendentes.");
            }

            _context.Pessoas.Remove(pessoa);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PessoaExists(int id)
        {
            return _context.Pessoas.Any(e => e.Id == id);
        }

        private async Task AtualizarStatusPessoa(int pessoaId)
        {
            var tarefas = await _context.Tarefas.Where(t => t.PessoaId == pessoaId).ToListAsync();
            var pessoa = await _context.Pessoas.FindAsync(pessoaId);

            if (pessoa != null && tarefas.All(t => t.Concluida))
            {
                pessoa.Status = StatusPessoa.Disponível;
                await _context.SaveChangesAsync();
            }
        }
    }
}
