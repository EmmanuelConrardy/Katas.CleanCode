using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Katas.CleanCode.Tests
{
    [TestClass]
    public class CalcPmManagerTests
    {
        private CalcPmManager calc;

        [TestInitialize]
        public void Initialize()
        {
            calc = new CalcPmManager();
        }

        [TestMethod]
        public void Should_return_no_Promotion_When_Nb_Product_is_Below_3()
        {
            var result = calc.GetPromotion(2, 10, 1);

            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void Should_return_One_free_Product_When_Nb_Product_is_Between_3_And_5()
        {
            var result = calc.GetPromotion(3, 10, 1);

            Assert.AreEqual(10,result);
        }

        [TestMethod]
        public void Should_return_Half_Price_Offer_Product_When_Nb_Product_is_Over_10()
        {
            var result = calc.GetPromotion(12, 10, 1);

            Assert.AreEqual(60, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Should_Throw_Exception_When_Negative_article_amount()
        {
            calc.GetPromotion(-1, 42, 1);
        }
    }
}
