using System;

namespace Abstract_Factory_Pattern
{
   static class Program
    {
        static void Main(string[] args)
        {
            IContinentFactory asiaFactory = new AsiaFactory();
            

            AnimalWorld animalWorld = new AnimalWorld(asiaFactory);
            animalWorld.RunFoodChain();

            IContinentFactory africaFactory = new AfricaFactory();

            animalWorld = new AnimalWorld(africaFactory);
            animalWorld.RunFoodChain();

            Console.Read();
        }
    }
}
