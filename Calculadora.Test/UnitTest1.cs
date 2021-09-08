using Calculadora.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSuma()
        {
            var s = Suma.Sum(1, 2);
            Assert.AreEqual(3,  s);
        }

        [TestMethod]
        public void TestSumaFail()
        {
            var s = Suma.Sum(-1, 2);
            Assert.AreEqual(-1, s);
        }

        [TestMethod]
        public void TestResta()
        {
            var r = Resta.Rest(3, 1);
            Assert.AreEqual(2, r);

        }

        [TestMethod]
        public void TestRestaFail()
        {
            var r = Resta.Rest(1, 3);
            Assert.AreNotEqual(2, r);
        }

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

        [TestMethod]
        public void TestDivision()
        {
            var d = Division.Div(6, 3);
            Assert.AreEqual(2, d);
        }

        [TestMethod]
        public void TestDivisionFail()
        {
            var d = Division.Div(6, 3);
            Assert.AreNotEqual(4, d);
        }

    }
}
