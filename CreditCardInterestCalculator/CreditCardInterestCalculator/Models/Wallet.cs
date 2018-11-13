using CreditCardInterestCalculator.Interfaces;

namespace CreditCardInterestCalculator.Models
{
    public class Wallet
    {
        private ICreditCard[] _cards;
        private double _interest;

        private Wallet(ICreditCard[] cardsToSet)
        {
            SetCreditCards(cardsToSet);
        }

        public ICreditCard[] SetCreditCards(ICreditCard[] cards)
        {
            return _cards = cards;
        }

        public ICreditCard[] GetCreditCards()
        {
            return _cards;
        }

        public void CalculateInterest()
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