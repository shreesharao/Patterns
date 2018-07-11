using System;

namespace Proxy_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            IMath mathProxy = new MathProxy();

            double num1 = 5, num2 = 10;
            Console.WriteLine($"Numbers : {nameof(num1)}:{num1} {nameof(num2)}:{num2}");

            Console.WriteLine($"Add : {mathProxy.Add(num1, num2)}");
            Console.WriteLine($"Substract :{mathProxy.Substract(num1, num2)}");
            Console.WriteLine($"Multiply :{ mathProxy.Multiply(num1, num2)}");
            Console.WriteLine($"Divide :{ mathProxy.Divide(num1, num2)}");
            
            Console.Read();
        }
    }
}
