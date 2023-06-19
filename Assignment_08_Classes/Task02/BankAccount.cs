using System;

namespace BankingServices
{
    public partial class BankAccount
    {
        private readonly string accountNumber;
        private Currency balance;
        private string accountHolderName;

        public string AccountNumber
        {
            get { return accountNumber; }
        }

        public string AccountHolderName
        {
            get { return accountHolderName; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    Console.WriteLine("Account holder name cannot be empty or whitespace.");
                }
                else
                {
                    accountHolderName = value;
                }
            }
        }

        public Currency Balance
        {
            get { return balance; }
        }

        public BankAccount(string accountNumber, string accountHolderName)
        {
            this.accountNumber = accountNumber;
            AccountHolderName = accountHolderName;
            balance = new Currency { CurrencyName = "USD", Amount = 0 };
        }

        public void Deposit(Currency amount)
        {
            if (amount.Amount <= 0)
            {
                Console.WriteLine("Deposit amount should be greater than zero.");
                return;
            }

            balance.Amount += amount.Amount;
        }

        public bool Withdraw(Currency amount)
        {
            if (amount.Amount <= 0)
            {
                Console.WriteLine("Withdrawal amount should be greater than zero.");
                return false;
            }

            if (balance.Amount >= amount.Amount)
            {
                balance.Amount -= amount.Amount;
                return true;
            }
            else
            {
                Console.WriteLine("Insufficient balance. Withdrawal failed.");
                return false;
            }
        }

        public string BalanceCheck()
        {
            return $"{balance.Amount} {balance.CurrencyName}";
        }
    }
}
