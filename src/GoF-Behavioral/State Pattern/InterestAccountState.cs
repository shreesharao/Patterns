namespace State_Pattern
{
    /// <summary>
    /// State that indicates the Account is actively accruing interest.
    /// 
    /// Behaves as a ConcreteState in the State pattern.
    /// </summary>
    internal class InterestAccountState : AccountState
    {
        private const double INTERESTRATE = 0.05;
        private const double LOWERLIMIT = 1000;

        public InterestAccountState(AccountState accountState) : this(accountState.Balance, accountState.Account)
        {

        }

        public InterestAccountState(double balance, Account account)
        {
            Account = account;
            Balance = balance;
        }

        public override double? AccureInterest()
        {
            var accuredInterest = INTERESTRATE * Balance;
            Balance += accuredInterest;
            TryStateChange();
            return accuredInterest;
        }

        public override bool Deposit(double amount)
        {
            Balance += amount;
            TryStateChange();
            return true;
        }

        public override void TryStateChange()
        {
            if (Balance < 0.0)
            {
                Account.AccountState = new OverdrawnAccountState(this);
            }
            else if (Balance < LOWERLIMIT)
            {
                Account.AccountState = new ZeroInterestAccountState(this);
            }
        }

        public override bool Withdraw(double amount)
        {
            Balance -= amount;
            TryStateChange();
            return true;
        }
    }
}