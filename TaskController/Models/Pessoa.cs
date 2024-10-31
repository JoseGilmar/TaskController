public enum StatusPessoa
{
    Disponível,
    Ocupado,
    Indisponível
}

public class Pessoa
{
    public int Id { get; set; }
    public string Nome { get; set; }
    public string Email { get; set; }
    public DateTime DataNascimento { get; set; }
    public StatusPessoa Status { get; set; }
    public List<Tarefa> Tarefas { get; set; } = new();
}
