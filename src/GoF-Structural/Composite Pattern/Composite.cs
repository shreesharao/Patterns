using System;
using System.Collections.Generic;

namespace Composite_Pattern
{
    class Composite : IComponent
    {
        public string Name { get; set; }
        public List<IComponent> elements { get; set; }

        public Composite(string name)
        {
            this.Name = name;
            this.elements = new List<IComponent>();
        }

        public void Add(IComponent component)
        {
            elements.Add(component);
        }


        public void Remove(IComponent component)
        {
            elements.Remove(component);
        }

        public void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) +
         "+ " + Name);

            // Display each child element on this node

            foreach (IComponent component in elements)
            {
                component.Display(indent + 2);
            }
        }

    }
}
