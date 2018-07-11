using System.Collections.Generic;

namespace Flyweight_Pattern
{
    class FlyweightFactory
    {
        private readonly Dictionary<string, IFlyweight> _flyweights = new Dictionary<string, IFlyweight>();

        // Constructor
        public FlyweightFactory()
        {

        }

        public IFlyweight GetFlyweight(string key)
        {
            if (_flyweights.ContainsKey(key))
            {
                return (_flyweights[key]);
            }
            else
            {
                ConcreteFlyweight concreteFlyweight = new ConcreteFlyweight();

                // Set properties of new flyweight here.

                _flyweights.Add(key, concreteFlyweight);
                return (_flyweights[key]);
            }

        }
    }
}
