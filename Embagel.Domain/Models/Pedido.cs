namespace Embagel.Business.Models
{
    public class Pedido : Entity
    {
        public DateTime DataPedido { get; set; }

        public List<Produto> Produtos { get; set; }
        public decimal ValorTotal { get; set; }
        public DateTime DataEntrega { get; set; }

        public int ClienteId { get; set; }
        public Cliente Cliente { get; set; }
    }
}
