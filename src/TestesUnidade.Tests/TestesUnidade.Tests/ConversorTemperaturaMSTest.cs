using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestesUnidade;

namespace TestesUnidade.Tests
{
    [TestClass]
    public class ConversorTemperaturaMSTest
    {
        [DataTestMethod]
        [DataRow(32, 0)]
        [DataRow(212, 100)]
        public void FahrenheitParaCelsius_Teste(double fahrenheit, double expectedCelsius)
        {
            double actualCelsius = ConversorTemperatura.FahrenheitParaCelsius(fahrenheit);
            Assert.AreEqual(expectedCelsius, actualCelsius);
        }
    }
}
