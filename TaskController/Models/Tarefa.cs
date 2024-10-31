using System;

namespace TaskManager.Models
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        public DateTime DataCriacao { get; set; }
        public string Status { get; set; } = "pendente"; // Valores possíveis: pendente, em progresso, concluída

        public int PessoaId { get; set; }
        public Pessoa Pessoa { get; set; }
    }
}
