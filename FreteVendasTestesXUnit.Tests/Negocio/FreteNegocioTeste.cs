using FreteVendasTestesXUnit.Negocio;

namespace FreteVendasTestesXUnit.Tests.Negocio
{
    public class FreteNegocioTeste
    {
        [Fact(DisplayName = "CalcularFreteComFact")]
        public void CalcularFreteFact()
        {
            //Arrange
            int distanciaFreteMenorQueCincoKm = 1;
            int distanciaFreteEntreCincoQuinzeKm = 10;
            int distanciaFreteMaiorqueQuinzeKm = 20;

            decimal freteEsperadoMenorQueCincoKm = 0.00m;
            decimal freteEsperadoEntreCincoQuinzeKm = 10.00m;
            decimal freteEsperadoMaiorQueQuinzeKm = 30.00m;

            //Act
            decimal freteMenorQueCincoKm = FreteNegocio.CalcularFrete(distanciaFreteMenorQueCincoKm);
            decimal freteEntreCincoQuinzeKm = FreteNegocio.CalcularFrete(distanciaFreteEntreCincoQuinzeKm);
            decimal freteMaiorQueQuinzeKm = FreteNegocio.CalcularFrete(distanciaFreteMaiorqueQuinzeKm);

            //Asserts
            Assert.Equal(freteEsperadoMenorQueCincoKm, freteMenorQueCincoKm);
            Assert.Equal(freteEsperadoEntreCincoQuinzeKm, freteEntreCincoQuinzeKm);
            Assert.Equal(freteEsperadoMaiorQueQuinzeKm, freteMaiorQueQuinzeKm);
        }

        [Theory(DisplayName = "CalcularFreteComTheory")]
        [InlineData(1)]
        [InlineData(2)]
        [InlineData(4)]
        [InlineData(10)]
        [InlineData(13)]
        [InlineData(15)]
        [InlineData(20)]
        [InlineData(35)]
        public void CalcularFreteTheory(int distanciaKm)
        {
            //Arrange
            decimal freteEsperadoMenorQueCincoKm = 0.00m;
            decimal freteEsperadoEntreCincoQuinzeKm = 10.00m;
            decimal freteEsperadoMaiorQueQuinzeKm = 30.00m;

            if (distanciaKm < 5)
            {
                //Act
                decimal valor = FreteNegocio.CalcularFrete(distanciaKm);

                //Assert
                Assert.Equal(freteEsperadoMenorQueCincoKm, valor);
            }
            else if (distanciaKm > 5 && distanciaKm < 15)
            {
                //Act
                decimal valor = FreteNegocio.CalcularFrete(distanciaKm);

                //Assert
                Assert.Equal(freteEsperadoEntreCincoQuinzeKm, valor);
            }
            else
            {
                //Act
                decimal valor = FreteNegocio.CalcularFrete(distanciaKm);

                //Assert
                Assert.Equal(freteEsperadoMaiorQueQuinzeKm, valor);
            }
        }
    }
}
