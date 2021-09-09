using Calculadora.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class TestFactorial
    {
        [TestMethod]
        public void TestFactorial1()
        {
            var f = Factorial.Fact(7);
            Assert.AreEqual(5040, f);
        }

        [TestMethod]
        public void TestFactorialFail()
        {
            var f = Factorial.Fact(7);
            Assert.AreNotEqual(2, f);
        }
    }
}
