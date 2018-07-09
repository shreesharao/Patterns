using System;

namespace Bridge_Pattern
{
    class SecondImplementation : IImplementorOrBridge
    {
        public void OperationImplementation()
        {
            Console.WriteLine("SecondImplementation:OperationImplementation()");
        }
    }
}
