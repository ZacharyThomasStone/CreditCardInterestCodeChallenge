using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CreditCardInterestCalculator.Interfaces;
using CreditCardInterestCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardInterestCalculator.Tests
{
    [TestClass]
    public class ChallengeTests
    {
        [TestMethod]
        public void FirstTestCase()
        {
            List<ICreditCard> cards = new List<ICreditCard>
            {
                new Visa(100),
                new MasterCard(100),
                new Discover(100),
             
            };
            
            List<Wallet> wallets = new List<Wallet>
            {
                new Wallet(cards)
            };

            Person person = new Person(wallets);
            double totalInterest = person.GetInterest();

            Assert.AreEqual(16, totalInterest);

        }

        [TestMethod]
        public void SecondTestCase()
        {
            List<ICreditCard> cardsForWalletOne = new List<ICreditCard>
            {
                new Visa(100),
                new Discover(100)

            };
            List<ICreditCard> cardsForWalletTwo = new List<ICreditCard>
            {
                new MasterCard(100)

            };

            List<Wallet> wallets = new List<Wallet>
            {
                new Wallet(cardsForWalletOne),
                new Wallet(cardsForWalletTwo)
            };

            Person person = new Person(wallets);
            double totalInterest = person.GetInterest();

            Assert.AreEqual(16, totalInterest);

        }

        [TestMethod]
        public void ThirdTestCase()
        {
            List<ICreditCard> cardsForPersonOneWallet = new List<ICreditCard>
            {
                new MasterCard(100),
                new Visa(100)

            };
            List<ICreditCard> cardsForPersonTwoWallet = new List<ICreditCard>
            {
                new Visa(100),
                new MasterCard(100)

            };

            List<Wallet> walletsForPersonOne = new List<Wallet>
            {
                new Wallet(cardsForPersonOneWallet),
            };
            List<Wallet> walletsForPersonTwo = new List<Wallet>
            {
                new Wallet(cardsForPersonTwoWallet),
            };

            Person person1 = new Person(walletsForPersonOne);
            Person person2 = new Person(walletsForPersonTwo);
            double totalInterestForPersonOne = person1.GetInterest();
            double totalInterestForPersonTwo = person2.GetInterest();

            Assert.AreEqual(15, totalInterestForPersonOne);
            Assert.AreEqual(15, totalInterestForPersonTwo);

        }
    }
}
