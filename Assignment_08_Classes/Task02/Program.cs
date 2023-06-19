using System;
using System.Security.Principal;

namespace BankingServices
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount("123456789", "John Doe");
            BankAccount account2 = new BankAccount("987654321", "Jane Smith");

            Console.WriteLine("Initial balances:");
            Console.WriteLine($"Account 1: {account1.Balance.CurrencyName} {account1.Balance.Amount}");
            Console.WriteLine($"Account 2: {account2.Balance.CurrencyName} {account2.Balance.Amount}");

            Currency depositAmount = new Currency { CurrencyName = "USD", Amount = 1000 };
            account1.Deposit(depositAmount);

            Console.WriteLine("After deposit:");
            Console.WriteLine($"Account 1: {account1.Balance.CurrencyName} {account1.Balance.Amount}");

            Currency withdrawalAmount = new Currency { CurrencyName = "USD", Amount = 500 };
            account1.Withdraw(withdrawalAmount);

            Console.WriteLine("After withdrawal:");
            Console.WriteLine($"Account 1: {account1.Balance.CurrencyName} {account1.Balance.Amount}");

            Currency transferAmount = new Currency { CurrencyName = "USD", Amount = 300 };
            account1.TransferFunds(account2, transferAmount);

            Console.WriteLine("Final balances:");
            Console.WriteLine($"Account 1: {account1.BalanceCheck()}");
            Console.WriteLine($"Account 2: {account2.BalanceCheck()}");

            Console.ReadLine();
        }
    }
}
