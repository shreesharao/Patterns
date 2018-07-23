using System;
using System.Collections.Generic;

namespace Observer_Pattern
{
    class Subject : ISubject
    {
        private readonly List<IObserver> _listObservers = new List<IObserver>();
        private double _price = 0;

        public double Price
        {
            get { return _price; }
            set
            {
                _price = value;
                Update();
            }
        }

        public void Subscribe(IObserver observer)
        {
            if (!_listObservers.Contains(observer))
            {
                Console.WriteLine($"Observer '{observer.Name}' subscribed");
                _listObservers.Add(observer);
            }

        }

        public void UnSubscribe(IObserver observer)
        {
            if (_listObservers.Contains(observer))
            {
                Console.WriteLine($"Observer '{observer.Name}' un-subscribed");
                _listObservers.Remove(observer);
            }

        }

        public void Update()
        {
            _listObservers.ForEach(observer => observer.Update(this));
        }
    }
}
