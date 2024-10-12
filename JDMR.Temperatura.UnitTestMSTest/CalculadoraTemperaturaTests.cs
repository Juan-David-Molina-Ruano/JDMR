using Microsoft.VisualStudio.TestTools.UnitTesting;
using JDMR.Temperatura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JDMR.Temperatura.Tests
{
    [TestClass()]
    public class CalculadoraTemperaturaTests
    {
        [TestMethod()]
        public void CelsiusAFahrenheitTest()
        {
            CalculadoraTemperatura calculadora = new CalculadoraTemperatura();

            double resultado = calculadora.CelsiusAFahrenheit(40);

            Assert.AreEqual(104, resultado);

        }

        [TestMethod()]
        public void FahrenheitACelsiusTest()
        {
            CalculadoraTemperatura calculadora = new CalculadoraTemperatura();

            double resultado = calculadora.FahrenheitACelsius(104);

            Assert.AreEqual(40, resultado);
        }
    }
}