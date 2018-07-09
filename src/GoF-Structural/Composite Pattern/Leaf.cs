using System;

namespace Composite_Pattern
{
    class Leaf : IComponent
    {
        public string Name { get; set; }

        public Leaf(string name)
        {
            this.Name = name;
        }

        public void Add(IComponent component)
        {
            Console.WriteLine("I am a leaf node.you can not add further nodes");
        }

        public void Display(int indent)
        {
            Console.WriteLine(Name);
        }

        public void Remove(IComponent component)
        {
            Console.WriteLine("I am a leaf node.you can remove nodes");
        }
    }
}
