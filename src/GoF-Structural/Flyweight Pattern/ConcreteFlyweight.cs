using System;

namespace Flyweight_Pattern
{
    class ConcreteFlyweight : IFlyweight
    {
        public void Operation(int extrinsicState)
        {
            Console.WriteLine($"ConcreteFlyweight: {extrinsicState}");
        }
    }
}
