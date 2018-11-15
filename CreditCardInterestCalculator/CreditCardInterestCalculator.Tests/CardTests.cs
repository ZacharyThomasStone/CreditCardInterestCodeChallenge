using CreditCardInterestCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardInterestCalculator.Tests
{
    [TestClass]
    public class CardTests
    {
        readonly Discover _discover = new Discover(100);
        readonly MasterCard _masterCard = new MasterCard(100);
        readonly Visa _visa = new Visa(100);


        //Discover Card Tests
        [TestMethod]
        public void TestDiscoverGetInterestRateMethod()
        {
            double interestRate = _discover.GetInterestRate();
            Assert.AreEqual(0.01, interestRate);
        }

        [TestMethod]
        public void TestDiscoverGetInterestMethod()
        {
            _discover.SetInterest();
            double interest = _discover.GetInterest();
            Assert.AreEqual(1, interest);
        }

        [TestMethod]
        public void TestDiscoverGetBalanceMethod()
        {
            double balance = _discover.GetBalance();
            Assert.AreEqual(100, balance);

        }

        //Master Card Tests
        [TestMethod]
        public void TestMasterCardGetInterestRateMethod()
        {
            double interestRate = _masterCard.GetInterestRate();
            Assert.AreEqual(0.05, interestRate);
        }

        [TestMethod]
        public void TestMasterCardGetInterestMethod()
        {
            _masterCard.SetInterest();
            double interest = _masterCard.GetInterest();
            Assert.AreEqual(5, interest);
        }

        [TestMethod]
        public void TestMasterCardGetBalanceMethod()
        {
            double balance = _masterCard.GetBalance();
            Assert.AreEqual(100, balance);

        }

        //Visa Card Tests
        [TestMethod]
        public void TestVisaCardGetInterestRateMethod()
        {
            double interestRate = _visa.GetInterestRate();
            Assert.AreEqual(0.10, interestRate);
        }

        [TestMethod]
        public void TestVisaCardGetInterestMethod()
        {
            _visa.SetInterest();
            double interest = _visa.GetInterest();
            Assert.AreEqual(10, interest);
        }

        [TestMethod]
        public void TestVisaCardGetBalanceMethod()
        {
            double balance = _visa.GetBalance();
            Assert.AreEqual(100, balance);

        }
    }
}
