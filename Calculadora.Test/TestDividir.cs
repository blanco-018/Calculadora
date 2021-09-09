using Calculadora.Classes;
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Calculadora.Test
{
    [TestClass]
    public class TestDividir
    {
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
