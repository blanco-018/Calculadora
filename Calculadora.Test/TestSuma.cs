using Calculadora.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class TestSuma
    {
        [TestMethod]
        public void TestSumar()
        {
            var s = Suma.Sum(1, 2);
            Assert.AreEqual(3,  s);
        }

        [TestMethod]
        public void TestSumarFail()
        {
            var s = Suma.Sum(-1, 2);
            Assert.AreEqual(-1, s);
        }
    }
}
