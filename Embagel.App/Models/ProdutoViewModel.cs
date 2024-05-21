using Embagel.Business.Models;

namespace Embagel.App.Models
{
    public class ProdutoViewModel
    {
        public Produto Produto { get; set; }
        public List<Fabricante> Fabricantes { get; set; }
    }
}
