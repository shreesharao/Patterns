namespace Abstract_Factory_Pattern
{
    class AnimalWorld
    {
        private IHerbivore _herbivore;
        private ICarnivore _carnivore;

        public AnimalWorld(IContinentFactory continentFactory)
        {
            _herbivore = continentFactory.CreateHerbivore();
            _carnivore = continentFactory.CreateCarnivore();
        }

        public void RunFoodChain()
        {
            _carnivore.Eat(_herbivore);
        }
    }
}
