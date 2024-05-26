using NUnit.Framework;
using TestesUnidade;

namespace TestesUnidade.Tests
{
    [TestFixture]
    public class ConversorTemperaturaNUnitTests
    {
        [TestCase(32, 0)]
        [TestCase(212, 100)]
        public void FahrenheitParaCelsius_Teste(double fahrenheit, double expectedCelsius)
        {
            double actualCelsius = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, actualCelsius);
        }
    }
}
