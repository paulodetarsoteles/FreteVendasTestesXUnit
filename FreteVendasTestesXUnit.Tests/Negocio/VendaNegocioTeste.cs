using FreteVendasTestesXUnit.Repositorio.Interfaces;
using Moq;

namespace FreteVendasTestesXUnit.Tests.Negocio
{
    public class VendaNegocioTeste
    {
        Mock<IVendasRepositorio> _vendasRepositorioMock;

        public VendaNegocioTeste()
        {
            _vendasRepositorioMock = new Mock<IVendasRepositorio>();
        }

        [Fact]
        public void CalcularMediaMensal()
        {

        }
    }
}
