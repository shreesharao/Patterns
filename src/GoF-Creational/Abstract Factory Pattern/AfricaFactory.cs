namespace Abstract_Factory_Pattern
{
    class AfricaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Wolf();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Wildbeest();
        }
    }
}
