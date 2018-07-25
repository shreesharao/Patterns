using System;
using System.Collections.Generic;

namespace Visitor_Pattern
{
    /// <summary>
    /// Client
    /// </summary>
    static class Program
    {
        static void Main(string[] args)
        {
            FruitPartitioner fruitPartitioner = new FruitPartitioner();
            List<IVisitable> fruits = new List<IVisitable>();
            fruits.AddRange(new List<IVisitable> {
                new Apple(),
                new Banana(),
                new Orange(),
                new Apple(),
                new Banana(),
                new Orange(),
            });

            foreach (var fruit in fruits)
            {
                fruit.Accept(fruitPartitioner);
            }

            Console.WriteLine(fruitPartitioner.ToString());
            Console.Read();
        }
    }
}
