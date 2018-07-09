using System;

namespace Bridge_Pattern
{
    public abstract class Abstraction
    {
        protected IImplementorOrBridge _implementorOrBridge { get; set; }

        protected Abstraction()
        {
            //assign concrete implementation
            _implementorOrBridge = new FirstImplementation();
        }
        public virtual void Operation()
        {
            Console.WriteLine("ImplementationBase:Operation()");
            _implementorOrBridge.OperationImplementation();
        }
    }
}
