namespace Embagel.Domain.Models
{
    public class Pessoa : Entity
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public DateTime DataNascimento { get; set; }
    }
}
