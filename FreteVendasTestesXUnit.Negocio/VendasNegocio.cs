using FreteVendasTestesXUnit.Entidades.Entidades;
using FreteVendasTestesXUnit.Repositorio.Interfaces;

namespace FreteVendasTestesXUnit.Negocio
{
    public class VendasNegocio
    {
        private readonly IVendasRepositorio _vendasRepo;

        public VendasNegocio(IVendasRepositorio vendasRepo) =>
            _vendasRepo = vendasRepo;

        public decimal CalcularMediaMensal(short mes, short ano)
        {
            IList<Vendas> vendas = _vendasRepo.BuscarVendas(mes, ano);

            decimal vendasMensal = (vendas.Sum(s => s.Valor)) / vendas.Count;

            decimal resultado = Math.Round(vendasMensal, 2);

            return resultado;
        }
    }
}
