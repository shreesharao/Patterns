using System;

namespace Bridge_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            RefinedAbstraction refinedAbstraction = new RefinedAbstraction();
            refinedAbstraction.Operation();

            Console.Read();
        }
    }
}
