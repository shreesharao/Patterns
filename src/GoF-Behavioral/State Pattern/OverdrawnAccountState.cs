using System;

namespace State_Pattern
{
    /// <summary>
    /// State that indicates the Account is overdrawn.
    /// 
    /// Behaves as a ConcreteState in the State pattern.
    /// </summary>
    internal class OverdrawnAccountState : AccountState
    {
        private const double UPPERLIMIT = 0;

        public OverdrawnAccountState(AccountState accountState) : this(accountState.Balance, accountState.Account)
        {

        }

        public OverdrawnAccountState(double balance, Account account)
        {
            Account = account;
            Balance = balance;
        }

        public override double? AccureInterest()
        {
            return null;
        }

        public override bool Deposit(double amount)
        {
            Balance += amount;
            TryStateChange();
            return true;
        }

        public override void TryStateChange()
        {
            if (Balance > UPPERLIMIT)
            {
                Account.AccountState = new ZeroInterestAccountState(this);
            }
        }

        public override bool Withdraw(double amount)
        {
            Console.WriteLine($"ALERT: Unable to withdraw {amount:C} due to lack of funds.");
            Console.WriteLine(Account.ToString());
            // Withdrawal failed.
            return false;
        }
    }
}