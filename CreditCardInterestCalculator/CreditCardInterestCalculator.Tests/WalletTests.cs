using System.Collections.Generic;
using CreditCardInterestCalculator.Interfaces;
using CreditCardInterestCalculator.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CreditCardInterestCalculator.Tests
{
    [TestClass]
    public class WalletTests
    {
        [TestMethod]
        public void TestWalletGetCreditCards()
        {
            List<ICreditCard> cards = new List<ICreditCard>
            {
                new Discover(100),
                new Visa(100)

            };
            Wallet wallet = new Wallet();
            wallet.SetCreditCards(cards);
            List<ICreditCard> cardsRetrieved = wallet.GetCreditCards();
            Assert.AreEqual(2,cardsRetrieved.Count);
        }
    }
}
