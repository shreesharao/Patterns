using System;

namespace Bridge_Pattern
{
    class RefinedAbstraction:Abstraction
    {
        public override void Operation()
        {
            Console.WriteLine("RefinedAbstraction:Operation()");
            _implementorOrBridge.OperationImplementation();
        }
    }
}
