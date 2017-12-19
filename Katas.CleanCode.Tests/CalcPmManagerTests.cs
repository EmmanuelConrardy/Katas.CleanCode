using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.CleanCode.Tests
{
    [TestClass]
    public class CalcPmManagerTests
    {
        [TestMethod]
        public void Calc()
        {
            var calc = new CalcPmManager();

            Assert.IsNotNull(calc);

        }

        [TestMethod]
        public void Calc2()
        {
            var calc = new CalcPmManager();

            //todo: faire le reste des tests

        }
    }
}
