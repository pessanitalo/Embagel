using Embagel.Business.Interface;
using Embagel.Business.Models;

namespace Embagel.Business.Service
{
    public class FabricanteService : IFabricanteService
    {
        private readonly IFabricanteRepository _fabricanteRepository;

        public FabricanteService(IFabricanteRepository fabricanteRepository)
        {
            _fabricanteRepository = fabricanteRepository;
        }

        public Fabricante Add(Fabricante model)
        {
            var fabricante = _fabricanteRepository.Add(model);
            return fabricante;

        }

        public List<Fabricante> GetAll()
        {
            var lista = _fabricanteRepository.GetAll();
            return lista;
        }
    }
}
