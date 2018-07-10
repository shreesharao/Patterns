using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    class Memory
    {
        public void Load(int memoryLocation)
        {
            Console.WriteLine($"Loading {nameof(memoryLocation)} {memoryLocation}");
        }
    }
}
