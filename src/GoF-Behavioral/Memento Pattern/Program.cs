using System;

namespace Memento_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            // Create an originator.
            var originator = new Originator<SalesProspect>();
            // Create a caretaker with passed originator instance.
            var caretaker = new Caretaker<SalesProspect>(originator);

            // Create sales prospect
            var salesProspect1 = new SalesProspect("SalesProspect1", "7760", 25000);
            var salesProspect2 = new SalesProspect("SalesProspect2", "1210", 11000);
            var salesProspect3 = new SalesProspect("SalesProspect3", "2584", 50000);

            // Set state to salesProspect1.
            originator.SetState(salesProspect1);
            // Save state.
            var memento1 = caretaker.Save();

            // Set state to salesProspect2.
            originator.SetState(salesProspect2);
            var memento2 = caretaker.Save();

            // Set state to salesProspect3.
            originator.SetState(salesProspect3);
            var memento3 = caretaker.Save();

            // Restore state back to salesProspect2.
            caretaker.Restore(memento2);

            // Restore state back to salesProspect1.
            caretaker.Restore(memento1);

            Console.Read();
        }
    }
}
