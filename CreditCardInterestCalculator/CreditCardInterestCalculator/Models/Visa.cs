﻿using CreditCardInterestCalculator.Interfaces;

namespace CreditCardInterestCalculator.Models
{
    public class Visa : ICreditCard
    {
        private readonly double _interestRate = 0.10;
        private double _balance;
        private double _interest;

        public Visa(double balance)
        {
            SetBalance(balance);
            SetInterest();
        }

        public double GetInterestRate()
        {
            return _interestRate;
        }

        public double GetInterest()
        {
            return _interest;
        }

        public double SetInterest()
        {
            return _interest = _balance * _interestRate;
        }

        public double GetBalance()
        {
            return _balance;
        }

        public double SetBalance(double balance)
        {
            return _balance = balance;
        }
    }
}