namespace Embagel.Business.Models
{
    public class Cliente : Pessoa
    {
        public Endereco Endereco { get; set; }
        public Pedido Pedido { get; set; }
    }
}
