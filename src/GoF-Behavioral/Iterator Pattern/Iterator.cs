namespace Iterator_Pattern
{
    class Iterator : IIterator
    {
        private readonly IAggregate _collection;
        private int _current = 0;
        private int _step = 1;

        // Gets or sets stepsize

        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Gets current iterator item

        public Item CurrentItem
        {
            get { return _collection[_current] as Item; }
        }

        // Gets whether iteration is complete

        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }

        public Iterator(IAggregate collection)
        {
            this._collection = collection;
        }

        public Item First()
        {
            _current = 0;
            return _collection[_current] as Item;
        }

        public Item Next()
        {
            _current += Step;
            if (!IsDone)
                return _collection[_current] as Item;
            else
                return null;
        }
    }
}
