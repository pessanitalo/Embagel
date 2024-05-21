using Embagel.Business.Models;


namespace Embagel.Business.Interface
{
    public interface IFabricanteRepository
    {
        Fabricante Add(Fabricante fabricante);
        List<Fabricante> GetAll();
    }
}
