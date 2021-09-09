using Calculadora.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class TestMultiplicar
    {
        [TestMethod]
        public void TestMuliplicar()
        {
            var m = Multiplicar.Mult(3, 5);
            Assert.AreEqual(15, m);

        }

        [TestMethod]
        public void TestMultiplicarFail()
        {
            var m = Multiplicar.Mult(3, 5);
            Assert.AreNotEqual(25, m);
        }
    }
}
