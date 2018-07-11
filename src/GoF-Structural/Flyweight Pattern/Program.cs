using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flyweight_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Arbitrary extrinsic state

            int extrinsicstate = 22;

            FlyweightFactory factory = new FlyweightFactory();

            // Work with different flyweight instances

            IFlyweight fx = factory.GetFlyweight("X");
            fx.Operation(--extrinsicstate);

            IFlyweight fy = factory.GetFlyweight("Y");
            fy.Operation(--extrinsicstate);

            IFlyweight fz = factory.GetFlyweight("Z");
            fz.Operation(--extrinsicstate);

            UnsharedConcreteFlyweight fu = new UnsharedConcreteFlyweight();

            fu.Operation(--extrinsicstate);

            // Wait for user

            Console.ReadKey();
        }
    }
}
