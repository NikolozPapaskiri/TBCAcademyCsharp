using System;

namespace BankingServices
{
    public partial class BankAccount
    {
        public void TransferFunds(BankAccount target, Currency amount)
        {
            if (amount.Amount <= 0)
            {
                Console.WriteLine("Transfer amount should be greater than zero.");
                return;
            }

            if (Withdraw(amount))
            {
                target.Deposit(amount);
                Console.WriteLine($"{amount.CurrencyName} {amount.Amount} transferred to {target.AccountNumber}");
            }
            else
            {
                Console.WriteLine("Transfer failed. Insufficient balance.");
            }
        }
    }
}
