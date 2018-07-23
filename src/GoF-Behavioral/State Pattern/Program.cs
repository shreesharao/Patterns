using System;

namespace State_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Create a new account.
            var account = new Account("Alice Smith");

            // Make a few deposits.
            account.Deposit(450);
            account.Deposit(500);
            // This deposit should increase balance 
            // enough to begin accruing interest.
            account.Deposit(550);
            account.Deposit(805);

            // Accrue interest.
            account.AccrueInterest();

            // Make a few withdrawals.
            account.Withdraw(2500);
            account.Withdraw(1500);

            Console.Read();
        }
    }
}
