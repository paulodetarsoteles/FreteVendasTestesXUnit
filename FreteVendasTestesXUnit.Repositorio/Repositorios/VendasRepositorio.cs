using FreteVendasTestesXUnit.Entidades.Entidades;
using FreteVendasTestesXUnit.Repositorio.Interfaces;

namespace FreteVendasTestesXUnit.Repositorio.Repositorios
{
    public class VendasRepositorio : IVendasRepositorio
    {
        public IList<Vendas> BuscarVendas(short mes, short ano)
        {
            #region Criação das instâncias

            var novaVenda1 = new Vendas()
            {
                Data = new DateTime(2021, 04, 02),
                Valor = 500.00m
            };

            var novaVenda2 = new Vendas()
            {
                Data = new DateTime(2021, 04, 15),
                Valor = 50.00m
            };

            var novaVenda3 = new Vendas()
            {
                Data = new DateTime(2021, 04, 20),
                Valor = 353.50m
            };

            var novaVenda4 = new Vendas()
            {
                Data = new DateTime(2021, 04, 20),
                Valor = 353.50m
            };

            var novaVenda5 = new Vendas()
            {
                Data = new DateTime(2021, 05, 20),
                Valor = 30.00m
            };

            var novaVenda6 = new Vendas()
            {
                Data = new DateTime(2021, 05, 25),
                Valor = 53.25m
            };

            var novaVenda7 = new Vendas()
            {
                Data = new DateTime(2021, 07, 10),
                Valor = 1353.50m
            };

            var novaVenda8 = new Vendas()
            {
                Data = new DateTime(2021, 09, 30),
                Valor = 300.50m
            };

            var novaVenda9 = new Vendas()
            {
                Data = new DateTime(2021, 09, 30),
                Valor = 200.00m
            };

            var listaVendas = new List<Vendas>()
            {
                novaVenda1,
                novaVenda2,
                novaVenda3,
                novaVenda4,
                novaVenda5,
                novaVenda6,
                novaVenda7,
                novaVenda8,
                novaVenda9
            };

            #endregion

            List<Vendas> resultado = [];

            resultado = listaVendas.Where(l => l.Data.Month == mes).ToList();

            if (resultado is not null && resultado.Count != 0)
            {
                return resultado;
            }
            else
            {
                return [];
            }
        }
    }
}
