using System;

namespace Facade_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting the computer...");
            ComputerFacade computerFacade = new ComputerFacade();

            //facade is hiding all the complex operations done when starting the computer
            computerFacade.Start();
            Console.WriteLine("Computer started..");

            Console.Read();
        }
    }
}
