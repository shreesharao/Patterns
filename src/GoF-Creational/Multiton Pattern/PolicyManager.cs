using System.Collections.Concurrent;

namespace Multiton_Pattern
{
    class PolicyManager
    {
        private readonly ConcurrentDictionary<string, Policy> _concurrentDictionary;

        public PolicyManager()
        {
            _concurrentDictionary = new ConcurrentDictionary<string, Policy>();
        }
        public Policy GetPolicy(string policyType)
        {
            var type = policyType.ToLower();
            if(!_concurrentDictionary.ContainsKey(type))
            {
                _concurrentDictionary.TryAdd(type, new Policy(type));
                return _concurrentDictionary[type];
            }

            return _concurrentDictionary[type];
        }
        
    }
}
