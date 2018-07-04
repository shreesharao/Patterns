using System.Collections.Generic;

namespace Prototype_Pattern
{
    class ColorManager
    {
        private readonly Dictionary<string, IPrototype> _dictionary = new Dictionary<string, IPrototype>();

        public IPrototype this[string key]
        {
            get
            {
                return _dictionary[key];
            }
            set
            {
                _dictionary.Add(key, value);
            }
        }
    }
}
