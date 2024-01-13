namespace Embagel.Domain.Models
{
    public class Produto : Entity
    {
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }
        public Fabricante Fabricante { get; set; }
        public int QuantidadeEstoque { get; set; }
        public string Cor { get; set; }
    }
}
