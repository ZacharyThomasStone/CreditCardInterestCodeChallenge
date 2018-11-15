using System.Collections.Generic;
using CreditCardInterestCalculator.Interfaces;

namespace CreditCardInterestCalculator.Models
{
    public class Wallet : IWallet
    {
        private List<ICreditCard> _cards;
        private double _interest;

        public Wallet(List<ICreditCard> cardsToSet)
        {
            SetCreditCards(cardsToSet);
            CalculateSimpleInterest();
        }

        public List<ICreditCard> SetCreditCards(List<ICreditCard> cards)
        {
            return _cards = cards;
        }


        public List<ICreditCard> GetCreditCards()
        {
            return _cards;
        }

        public void CalculateSimpleInterest()
        {
            foreach (ICreditCard card in _cards)
            {
                _interest += card.GetInterest();
            }

        }

        public double GetInterest()
        {
            return _interest;
        }

        public double SetInterest(double interest)
        {
            return _interest = interest;
        }

    }
}