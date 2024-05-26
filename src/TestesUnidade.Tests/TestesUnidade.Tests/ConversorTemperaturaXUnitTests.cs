using Xunit;
using TestesUnidade;

namespace TestesUnidade.Tests
{
    public class ConversorTemperaturaXUnitTests
    {
        [Theory]
        [InlineData(32, 0)]
        [InlineData(212, 100)]
        public void FahrenheitParaCelsius_Teste(double fahrenheit, double expectedCelsius)
        {
            double actualCelsius = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.Equal(expectedCelsius, actualCelsius);
        }
    }
}
