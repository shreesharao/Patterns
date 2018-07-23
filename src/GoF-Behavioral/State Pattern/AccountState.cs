namespace State_Pattern
{
    /// <summary>
    /// Base state to which an Account can be assigned.
    /// Cannot be directly inherited.
    /// 
    /// Behaves as a State in the State pattern.
    /// </summary>
    abstract class AccountState
    {
        public Account Account { get; set; }
        public double Balance { get; set; }

        public abstract double? AccureInterest();
        public abstract bool Deposit(double amount);
        public abstract void TryStateChange();
        public abstract bool Withdraw(double amount);

    }
}
