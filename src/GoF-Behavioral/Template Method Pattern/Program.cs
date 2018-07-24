using System;

namespace Template_Method_Pattern
{
    /// <summary>
    /// Client
    /// </summary>
    static class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("====Categories====");
            DataAccessObject dataAccessObject = new Categories();

            //Invoke template method
            dataAccessObject.Run();

            Console.WriteLine("====Products====");

            dataAccessObject = new Products();

            //Invoke template method
            dataAccessObject.Run();

            Console.Read();

        }
    }
}
