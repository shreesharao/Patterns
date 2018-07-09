using System;

namespace Composite_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("Root");
            root.Add(new Leaf("Leaf1"));
            root.Add(new Leaf("Leaf2"));

            Composite compositeNode = new Composite("compositeNode");
            compositeNode.Add(new Leaf("Leaf1"));
            compositeNode.Add(new Leaf("Leaf2"));
            root.Add(compositeNode);

            root.Display(1);
            Console.Read();
        }
    }
}
