using System;

namespace State_Pattern
{
    /// <summary>
    /// Customer account, which retains an ongoing balance and state.
    /// 
    /// Behaves as a Context object in the State pattern.
    /// </summary>
    class Account
    {
        private readonly string _owner;

        public double Balance => AccountState.Balance;
        public AccountState AccountState { get; set; }

        public Account(string owner)
        {
            _owner = owner;
            AccountState = new ZeroInterestAccountState(0, this);
        }

        public void Deposit(double amount)
        {

            // Ensure deposit was successful.
            if (!AccountState.Deposit(amount)) return;
            Console.WriteLine($"Deposited: {amount:C}"); 
        }

        public double? AccrueInterest()
        {
            var interest = AccountState.AccureInterest();
            Console.WriteLine($"Accure Interest: {interest:C}");
            return interest;
        }

        public void Withdraw(double amount)
        {
            // Ensure withdrawal was successful.
            if (!AccountState.Withdraw(amount)) return;
            Console.WriteLine($"Withdrawn: {amount:C}");
        }
        public override string ToString()
        {
            var output = $"{"ACCOUNT OWNER",-20}{"BALANCE",-20}STATE\n";
            output += $"{_owner,-20}{Balance,-20:C}{AccountState.GetType().Name}";

            return output;
        }
    }
}
