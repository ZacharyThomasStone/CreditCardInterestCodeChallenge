namespace CreditCardInterestCalculator.Interfaces
{
    public interface ICreditCard
    {
        double GetInterestRate();
        double GetInterest();
        double SetInterest();
        double GetBalance();
        double SetBalance(double balance);

    }
}