using System;

namespace Adapter_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            Client client = new Client();
            client.Entry();

            Console.Read();
        }
    }
}
