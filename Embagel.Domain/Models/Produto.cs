namespace Embagel.Domain.Models
{
    public class Produto : Entity
    {
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }      
        public int QuantidadeEstoque { get; set; }
        public string Cor { get; set; }

        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }

        public Produto(string descricao, decimal valorUnitario, int quantidadeEstoque, string cor)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            QuantidadeEstoque = quantidadeEstoque;
            Cor = cor;
        }
    }
}
