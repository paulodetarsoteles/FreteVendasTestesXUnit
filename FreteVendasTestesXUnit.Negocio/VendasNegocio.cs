using FreteVendasTestesXUnit.Entidades.Entidades;
using FreteVendasTestesXUnit.Repositorio.Interfaces;

namespace FreteVendasTestesXUnit.Negocio
{
    public class VendasNegocio
    {
        private readonly IVendasRepositorio _vendasRepo;

        public VendasNegocio(IVendasRepositorio vendasRepo) =>
            _vendasRepo = vendasRepo;

        public decimal CalcularVendasTotalPorAno(short ano)
        {
            try
            {
                IList<Vendas> vendas = _vendasRepo.BuscarVendas(ano);

                if (vendas is null || vendas.Count == 0)
                    throw new Exception($"Nenhuma venda para o ano {ano}.");

                decimal vendasAnual = 0.00m;

                foreach (var venda in vendas)
                {
                    vendasAnual += venda.Valor;
                }

                decimal resultado = Math.Round(vendasAnual, 2);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public decimal CalcularMediaMensal(short mes, short ano)
        {
            try
            {
                IList<Vendas> vendas = _vendasRepo.BuscarVendas(mes, ano);

                if (vendas is null || vendas.Count == 0)
                    throw new Exception($"Nenhuma venda para o período de {mes}/{ano}.");

                decimal vendasMensal = (vendas.Sum(s => s.Valor)) / vendas.Count;

                decimal resultado = Math.Round(vendasMensal, 2);

                return resultado;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
