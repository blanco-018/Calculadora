using Calculadora.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class TestFibonacci
    {
        [TestMethod]
        public void TestFibonacci1()
        {
            var fi = Fibonacci.Fibon(6);
            Assert.AreEqual(8, fi);
        }

        [TestMethod]
        public void TestFibonacciFail()
        {
            var fi = Fibonacci.Fibon(6);
            Assert.AreNotEqual(9, fi);
        }
    }
}
