using Embagel.Business.Interface;
using Embagel.Business.Models;
using Embagel.Data.Context;

namespace Embagel.Data.Repository
{
    public class ProdutoRepository : IProdutoRepository
    {
        private readonly DataContext _dataContext;

        public ProdutoRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Produto Add(Produto produto)
        {
            _dataContext.Add(produto);
            _dataContext.SaveChanges();
            return produto;

        }
    }
}
