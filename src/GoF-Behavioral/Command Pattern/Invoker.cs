using System;
using System.Collections.Generic;

namespace Command_Pattern
{
    class Invoker
    {
        private readonly List<ICommand> _commands;
        private readonly Stack<ICommand> _executedCommands;
        
        public Invoker()
        {
            _executedCommands = new Stack<ICommand>();
            _commands = new List<ICommand>();
           
        }

        public void AddCommand(ICommand command)
        {
            _commands.Add(command);
        }

        public void ExecuteCommands()
        {
            try
            {
                _commands.ForEach(command =>
                {
                    _executedCommands.Push(command);
                    command.Execute();
                });
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"An exception has occured..{ex.Message}..Rolling back..");
                if (_executedCommands.Count > 0)
                {
                    _executedCommands.Pop().Rollback();
                }
            }
        }
    }
}
