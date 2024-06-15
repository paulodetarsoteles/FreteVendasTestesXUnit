using FreteVendasTestesXUnit.Entidades.Entidades;

namespace FreteVendasTestesXUnit.Repositorio.Interfaces
{
    public interface IVendasRepositorio
    {
        IList<Vendas> BuscarVendas(short mes, short ano);
    }
}
