using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace PruebasUnitarias
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int valor1 = 10;
            int valor2 = 20;

            int resp = 30;

            int resultado = valor1 + valor2;

            Assert.IsTrue(resp != resultado, "Algo Salio mal");

        }
    }
}
