using FreteVendasTestesXUnit.Entidades.Entidades;
using FreteVendasTestesXUnit.Negocio;
using FreteVendasTestesXUnit.Repositorio.Interfaces;
using Moq;

namespace FreteVendasTestesXUnit.Tests.Negocio
{
    public class VendaNegocioTeste
    {
        private readonly Mock<IVendasRepositorio> _vendasRepositorioMock;
        private readonly VendasNegocio _vendasNegocio;

        public VendaNegocioTeste()
        {
            #region Criação das instâncias

            var novaVenda1 = new Vendas()
            {
                Data = new DateTime(2021, 04, 10),
                Valor = 100.00m
            };

            var novaVenda2 = new Vendas()
            {
                Data = new DateTime(2021, 04, 15),
                Valor = 200.00m
            };

            var novaVenda3 = new Vendas()
            {
                Data = new DateTime(2021, 04, 20),
                Valor = 300.00m
            };

            var listaVendas = new List<Vendas>()
            {
                novaVenda1,
                novaVenda2,
                novaVenda3
            };

            #endregion

            _vendasRepositorioMock = new Mock<IVendasRepositorio>();

            _vendasRepositorioMock.Setup(v => v.BuscarVendas(It.IsAny<short>()))
                .Returns(listaVendas);

            _vendasRepositorioMock.Setup(v => v.BuscarVendas(It.IsAny<short>(), It.IsAny<short>()))
                .Returns(listaVendas);

            _vendasNegocio = new VendasNegocio(_vendasRepositorioMock.Object);
        }

        [Fact]
        public void CalcularVendasTotalPorAno()
        {
            //Arrange
            short ano = 2021;
            decimal resultadoEsperado = 600.00m;

            //Act 
            decimal resultadoMetodo = _vendasNegocio.CalcularVendasTotalPorAno(ano);

            //Assert 
            Assert.Equal(resultadoEsperado, resultadoMetodo);
        }

        [Fact]
        public void CalcularMediaMensal()
        {
            //Arrange
            short mes = 4;
            short ano = 2021;
            decimal resultadoEsperado = 200.00m;

            //Act
            decimal resultadoMetodo = _vendasNegocio.CalcularMediaMensal(mes, ano);

            //Assert
            Assert.Equal(resultadoEsperado, resultadoMetodo);
        }
    }
}
