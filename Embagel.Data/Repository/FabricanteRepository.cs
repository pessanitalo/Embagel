using Embagel.Business.Interface;
using Embagel.Business.Models;
using Embagel.Data.Context;

namespace Embagel.Data.Repository
{
    public class FabricanteRepository : IFabricanteRepository
    {
        private readonly DataContext _dataContext;

        public FabricanteRepository(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public Fabricante Add(Fabricante fabricante)
        {
            _dataContext.Add(fabricante);
            _dataContext.SaveChanges();
            return fabricante;
        }

        public List<Fabricante> GetAll()
        {
            var list = _dataContext.Fabricantes.ToList();
            return list;
        }
    }
}
