using System;

namespace Observer_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            ISubject subject = new Subject();
            var Observer1 = new Observer("Observer1");
            subject.Subscribe(Observer1);
            subject.Subscribe(new Observer("Observer2"));
            subject.Subscribe(new Observer("Observer3"));

            subject.Price = 100;

            subject.UnSubscribe(Observer1);

            subject.Price = 200;

            Console.Read();
        }
    }
}
