using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CreditCardInterestCalculator.Models;

namespace CreditCardInterestCalculator.Interfaces
{
    public interface IPerson
    {
        List<Wallet> SetWallets(List<Wallet> wallets);
        List<Wallet> GetWallets();
    }
}