using System;

namespace Observer_Pattern
{
    class Observer : IObserver
    {
        public string Name { get; set; }
        public Observer(string name)
        {
            Name = name;
        }
        public void Update(ISubject subject)
        {
            Console.WriteLine($"Observer '{Name}' notified of changed price :'{subject.Price}'");
        }
    }
}
