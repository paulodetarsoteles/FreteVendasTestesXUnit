using FreteVendasTestesXUnit.Entidades.Entidades;
using FreteVendasTestesXUnit.Repositorio.Interfaces;

namespace FreteVendasTestesXUnit.Repositorio.Repositorios
{
    public class VendasRepositorio : IVendasRepositorio
    {
        public IList<Vendas> BuscarVendas(short mes, short ano)
        {
            var novaVenda1 = new Vendas()
            {
                Data = new DateTime(2021, 04, 02),
                Valor = 500.00m
            };

            var novaVenda2 = new Vendas()
            {
                Data = new DateTime(2021, 04, 02),
                Valor = 500.00m
            };

            var resultado = new List<Vendas>()
            {
                novaVenda1,
                novaVenda2
            };

            return resultado;
        }
    }
}
