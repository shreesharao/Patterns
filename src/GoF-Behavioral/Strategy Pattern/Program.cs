using System;

namespace Strategy_Pattern
{
    /// <summary>
    /// This behaves as client in strategy pattern
    /// </summary>
    static class Program
    {
        static void Main(string[] args)
        {
            IPackage letter = new Package("Letter");

            Packager packager = new Packager(new FlatStrategy());
            packager.Pack(letter);
            Console.WriteLine(letter.ToString());

            IPackage monitor = new Package("Computer Monitor");
            packager = new Packager(new FragileStrategy());
            packager.Pack(monitor);
            Console.WriteLine(monitor.ToString());

            Console.Read();
        }
    }
}
