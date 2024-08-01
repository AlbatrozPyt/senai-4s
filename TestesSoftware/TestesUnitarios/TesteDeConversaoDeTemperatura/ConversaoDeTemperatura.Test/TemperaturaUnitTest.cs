using Xunit;

namespace ConversaoDeTemperatura.Test
{
    public class TemperaturaUnitTest
    {
        [Theory]
        [InlineData(7)]
        [InlineData(0)]
        public void ConverterTemperatura(double temp)
        {
            var res = Temperatura.ConverterParaFahrenheit(temp);

            double valorEsperado = 44.6;

            Assert.Equal(valorEsperado, res);
        }
    }
}