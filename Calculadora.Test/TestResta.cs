using Calculadora.Classes;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Calculadora.Test
{
    [TestClass]
    public class TestResta
    {
        [TestMethod]
        public void TestRestar()
        {
            var r = Resta.Rest(3, 1);
            Assert.AreEqual(2, r);
        }

        [TestMethod]
        public void TestRestarFail()
        {
            var r = Resta.Rest(1, 3);
            Assert.AreNotEqual(2, r);
        }
    }
}
