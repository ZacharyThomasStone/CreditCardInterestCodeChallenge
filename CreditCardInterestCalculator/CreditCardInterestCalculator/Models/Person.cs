using System.Collections.Generic;
using CreditCardInterestCalculator.Interfaces;

namespace CreditCardInterestCalculator.Models
{
    public class Person : IPerson
    {
        private List<Wallet> _wallets;
        private double _interest;

        public Person(List<Wallet> wallets)
        {
            SetWallets(wallets);
            CalculateTotalInterest();

        }

        public List<Wallet> SetWallets(List<Wallet> wallets)
        {
            return _wallets = wallets;
        }

        public List<Wallet> GetWallets()
        {
            return _wallets;
        }

        public double CalculateTotalInterest()
        {
            foreach (var wallet in _wallets)
            {
                _interest += wallet.GetInterest();
            }

            return _interest;

        }
        public double SetInterest(double interest)
        {
            return _interest = interest;
        }

        public double GetInterest()
        {
            return _interest;
        }
    }
}