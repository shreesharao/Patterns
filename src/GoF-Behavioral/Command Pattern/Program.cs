using System;

namespace Command_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Calculator calculator = new Calculator();
            ICommand command = new CalculatorCommand(calculator, '+', 10);
            ICommand command1 = new CalculatorCommand(calculator, '+', 10);
            ICommand command2 = new CalculatorCommand(calculator, '-', 10);
            ICommand command3 = new CalculatorCommand(calculator, '*', 10);

            Invoker invoker = new Invoker();
            invoker.AddCommand(command);
            invoker.AddCommand(command1);
            invoker.AddCommand(command2);
            invoker.AddCommand(command3);

            invoker.ExecuteCommands();

            Console.Read();
        }
    }
}
