namespace Embagel.Business.Models
{
    public class Produto : Entity
    {
        public string Descricao { get; set; }
        public decimal ValorUnitario { get; set; }      
        public long QuantidadeEstoque { get; set; }
        public string Cor { get; set; }
        public int FabricanteId { get; set; }
        public Fabricante Fabricante { get; set; }

        public Produto() { }

        public Produto(string descricao, decimal valorUnitario, long quantidadeEstoque, string cor)
        {
            Descricao = descricao;
            ValorUnitario = valorUnitario;
            QuantidadeEstoque = quantidadeEstoque;
            Cor = cor;
        }
    }
}
