using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CreditCardInterestCalculator.Interfaces
{
    public interface IWallet
    {
        List<ICreditCard> GetCreditCards();
        List<ICreditCard> SetCreditCards(List<ICreditCard> cards);
        void CalculateSimpleInterest();
        double GetInterest();
        double SetInterest(double interest);
    }
}