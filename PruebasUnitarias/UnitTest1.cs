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

            Assert.IsTrue(resp == 30, "Salio mal");

        }
    }
}
