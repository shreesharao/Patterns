using System;

namespace Template_Method_Pattern
{
    /// <summary>
    /// A 'ConcreteClass' class
    /// </summary>
    class Categories : DataAccessObject
    {
        public override void Process()
        {
            Console.WriteLine("Processing Categories");
        }

        public override void Select()
        {
            Console.WriteLine("Selecting Categories");
        }
    }
}
