namespace Embagel.Business.Models
{
    public class Fabricante : Entity
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        //public Endereco Endereco { get; set; }
        public List<Produto> Produtos { get; set; }
    }
}
