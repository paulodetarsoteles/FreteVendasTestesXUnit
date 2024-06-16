using FreteVendasTestesXUnit.Entidades.Entidades;
using FreteVendasTestesXUnit.Repositorio.Interfaces;

namespace FreteVendasTestesXUnit.Repositorio.Repositorios
{
    public class VendasRepositorio : IVendasRepositorio
    {
        #region Criação das instâncias

        private List<Vendas> listaVendas =
        [
            new Vendas
            {
                Data = new DateTime(2021, 09, 30),
                Valor = 200.00m
            },
            new Vendas
            {
                Data = new DateTime(2021, 09, 30),
                Valor = 300.50m
            },
            new Vendas
            {
                Data = new DateTime(2021, 07, 10),
                Valor = 1353.50m
            },
            new Vendas
            {
                Data = new DateTime(2021, 05, 25),
                Valor = 53.25m
            },
            new Vendas
            {
                Data = new DateTime(2021, 05, 20),
                Valor = 30.00m
            },
            new Vendas
            {
                Data = new DateTime(2021, 04, 20),
                Valor = 353.50m
            },
            new Vendas
            {
                Data = new DateTime(2021, 04, 20),
                Valor = 353.50m
            },
            new Vendas
            {
                Data = new DateTime(2021, 04, 15),
                Valor = 50.00m
            },
            new Vendas
            {
                Data = new DateTime(2021, 04, 02),
                Valor = 500.00m
            }
        ];

        #endregion

        public IList<Vendas> BuscarVendas(short ano)
        {
            List<Vendas> resultado = [];

            resultado = listaVendas.Where(l => l.Data.Year == ano).ToList();

            if (resultado is not null && resultado.Count != 0)
            {
                return resultado;
            }
            else
            {
                return [];
            }
        }

        public IList<Vendas> BuscarVendas(short mes, short ano)
        {
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
