using Embagel.App.Models;
using Embagel.Business.Models;
using Embagel.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace Embagel.App.Controllers
{
    public class ProdutoController : Controller
    {
        private readonly DataContext _dataContext;

        public ProdutoController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            return View(_dataContext.Produtos.ToList());
        }

        public IActionResult Create()
        {
            var fabricantes = _dataContext.Fabricantes.ToList();
            var viewModel = new ProdutoViewModel { Fabricantes = fabricantes };
            return View(viewModel);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Produto produto)
        {
            _dataContext.Add(produto);
            _dataContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
