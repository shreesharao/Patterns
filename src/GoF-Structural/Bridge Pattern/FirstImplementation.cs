using System;

namespace Bridge_Pattern
{
    class FirstImplementation : IImplementorOrBridge
    {
        public void OperationImplementation()
        {
            Console.WriteLine("FirstImplementation:OperationImplementation()");
        }
    }
}
