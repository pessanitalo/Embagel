using Embagel.Business.Interface;
using Embagel.Business.Models;
using Embagel.Data.Context;
using Microsoft.AspNetCore.Mvc;

namespace Embagel.App.Controllers
{
    public class FabricanteController : Controller
    {
        private readonly IFabricanteService _fabricanteService;
        private readonly DataContext _dataContext;

        public FabricanteController(IFabricanteService fabricanteService, DataContext dataContext)
        {
            _fabricanteService = fabricanteService;
            _dataContext = dataContext;
        }

        public IActionResult Index()
        {
            var lista = _fabricanteService.GetAll();
            return View(lista);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Novofabricante(Fabricante fabricante)
        {
   
            _dataContext.Add(fabricante);
            _dataContext.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}
