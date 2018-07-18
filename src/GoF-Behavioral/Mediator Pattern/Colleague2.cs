using System;

namespace Mediator_Pattern
{
    class Colleague2 : IColleague
    {
        public string Name { get; set; }
        public IMediator Mediator { get; set; }

        public Colleague2(string name,IMediator mediator)
        {
            this.Name = name;
            this.Mediator = mediator;
            Mediator.Subscribe(this);
        }

        public void Listen(string message, IColleague colleague)
        {
            // If source is self, ignore.
            if (colleague == this) return;
            Console.WriteLine($"{colleague.Name} to {Name} : '{message}'");
        }

        public void Say(string message)
        {
            Mediator.PublishMessage(message, this);
        }
    }
}
