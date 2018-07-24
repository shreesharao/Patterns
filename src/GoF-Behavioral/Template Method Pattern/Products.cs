using System;

namespace Template_Method_Pattern
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Products : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Processing Products");
        }

        public override void Select()
        {
            Console.WriteLine("Selecting Products");
        }
    }
}
