using System;

namespace Mediator_Pattern
{
    /// <summary>
    /// Mediator pattern client
    /// </summary>
    static class Program
    {
        static void Main(string[] args)
        {
            IMediator mediator = new Mediator();

            IColleague arya = new Colleague1("Arya", mediator);
            IColleague tyrian = new Colleague2("Tyrian", mediator);
            IColleague cersei = new Colleague2("cersei", mediator);
            
            arya.Say("Valar morghulis");
            tyrian.Say("Never forget what you are, for surely the world will not.");
            cersei.Say("When you play the game of thrones, you win or you die.There is no middle ground.");

            Console.Read();
        }
    }
}
