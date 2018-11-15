using System;
using CreditCardInterestCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardInterestCalculator.Tests
{
    [TestClass]
    public class CardTests
    {
        Discover discover = new Discover(100);
        MasterCard masterCard = new MasterCard(100);
        Visa visa = new Visa(100);


        //Discover Card Tests
        [TestMethod]
        public void TestDiscoverGetInterestRateMethod()
        {
            double interestRate = discover.GetInterestRate();
            Assert.AreEqual(0.01, interestRate);
        }

        [TestMethod]
        public void TestDiscoverGetInterestMethod()
        {
            discover.SetInterest();
            double interest = discover.GetInterest();
            Assert.AreEqual(1, interest);
        }

        [TestMethod]
        public void TestDiscoverGetBalanceMethod()
        {
            double balance = discover.GetBalance();
            Assert.AreEqual(100, balance);

        }

        //Master Card Tests
        [TestMethod]
        public void TestMasterCardGetInterestRateMethod()
        {
            double interestRate = masterCard.GetInterestRate();
            Assert.AreEqual(0.05, interestRate);
        }

        [TestMethod]
        public void TestMasterCardGetInterestMethod()
        {
            masterCard.SetInterest();
            double interest = masterCard.GetInterest();
            Assert.AreEqual(5, interest);
        }

        [TestMethod]
        public void TestMasterCardGetBalanceMethod()
        {
            double balance = masterCard.GetBalance();
            Assert.AreEqual(100, balance);

        }

        //Visa Card Tests
        [TestMethod]
        public void TestVisaCardGetInterestRateMethod()
        {
            double interestRate = visa.GetInterestRate();
            Assert.AreEqual(0.10, interestRate);
        }

        [TestMethod]
        public void TestVisaCardGetInterestMethod()
        {
            visa.SetInterest();
            double interest = visa.GetInterest();
            Assert.AreEqual(10, interest);
        }

        [TestMethod]
        public void TestVisaCardGetBalanceMethod()
        {
            double balance = visa.GetBalance();
            Assert.AreEqual(100, balance);

        }
    }
}
