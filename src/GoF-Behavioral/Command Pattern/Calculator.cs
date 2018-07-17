using System;

namespace Command_Pattern
{
    /// <summary>
    /// The 'Receiver' class
    /// </summary>
    class Calculator
    {
        private int _curr = 0;

        public void Operation(char @operator, int operand)
        {
            switch (@operator)
            {
                case '+': _curr += operand; break;
                case '-': _curr -= operand; break;
                case '*': _curr *= operand; break;
                case '/': _curr /= operand; break;
            }
            Console.WriteLine($"Current value = {_curr,3} (following {@operator} {operand})");
        }
    }
}
