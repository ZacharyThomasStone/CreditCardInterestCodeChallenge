using System.Collections.Generic;
using CreditCardInterestCalculator.Models;

namespace CreditCardInterestCalculator.Interfaces
{
    public interface IPerson
    {
        List<Wallet> SetWallets(List<Wallet> wallets);
        List<Wallet> GetWallets();
        double CalculateTotalInterest();
        double GetInterest();
        double SetInterest(double interest);
    }
}