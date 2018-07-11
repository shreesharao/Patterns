using System;

namespace Flyweight_Pattern
{
    class UnsharedConcreteFlyweight : IFlyweight
    {
        public void Operation(int extrinsicState)
        {
            Console.WriteLine($"UnsharedConcreteFlyweight: {extrinsicState}");
        }
    }
}
