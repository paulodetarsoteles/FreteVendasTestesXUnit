using FreteVendasTestesXUnit.Negocio;

namespace FreteVendasTestesXUnit.Tests.Negocio
{
    public class VendaNegocioTeste
    {
        [Fact(DisplayName = "CalcularFrete")]
        public void CalcularFrete()
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
    }
}
