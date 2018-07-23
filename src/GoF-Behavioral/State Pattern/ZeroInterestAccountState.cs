namespace State_Pattern
{
    /// <summary>
    /// State that indicates the Account is not accruing interest.
    /// 
    /// Behaves as a ConcreteState in the State pattern.
    /// </summary>
    class ZeroInterestAccountState : AccountState
    {
        private const double INTERESTRATE = 0;
        private const double UPPERLIMIT = 1000;
        private const double LOWERLIMIT = 00;

        public ZeroInterestAccountState(AccountState accountState) : this(accountState.Balance, accountState.Account)
        {

        }

        public ZeroInterestAccountState(double balance, Account account)
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
            if (Balance < LOWERLIMIT)
            {
                Account.AccountState = new OverdrawnAccountState(this);
            }
            else if (Balance > UPPERLIMIT)
            {
                Account.AccountState = new InterestAccountState(this);
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
