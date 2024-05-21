using Embagel.Business.Interface;
using Embagel.Business.Models;

namespace Embagel.Business.Service
{
    public class ProdutoService : IProdutoService
    {
        private readonly IProdutoRepository _produtoRepository;

        public ProdutoService(IProdutoRepository produtoRepository)
        {
            _produtoRepository = produtoRepository;
        }

        public Produto Add(Produto produto)
        {
            var prod = _produtoRepository.Add(produto);
            return prod;
        }
    }
}
