namespace Embagel.Domain.Models
{
    public class Pedido : Entity
    {
        public DateTime DataPedido { get; set; }
        public List<Produto> Produtos { get; set; }
        public Cliente Cliente { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataEntrega { get; set; }
        public Endereco EnderecoEntrega { get; set; }
    }
}
