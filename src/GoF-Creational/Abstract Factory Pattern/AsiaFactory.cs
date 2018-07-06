namespace Abstract_Factory_Pattern
{
    class AsiaFactory : IContinentFactory
    {
        public ICarnivore CreateCarnivore()
        {
            return new Lion();
        }

        public IHerbivore CreateHerbivore()
        {
            return new Bison();
        }
    }
}
