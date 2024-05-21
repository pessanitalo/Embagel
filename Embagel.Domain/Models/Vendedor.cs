namespace Embagel.Business.Models
{
    public class Vendedor : Pessoa
    {
        public IEnumerable<Pedido> Pedidos { get; set; }
    }
}
