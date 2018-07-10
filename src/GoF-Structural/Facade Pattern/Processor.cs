using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Processor
    {
        public void Freeze()
        {
            Console.WriteLine("Freezing the processor...");
        }

        public void Jump(int location)
        {
            Console.WriteLine($"Jumping to location {location}...");
        }

        public void Execute()
        {
            Console.WriteLine($"Executing..");
        }
    }
}
