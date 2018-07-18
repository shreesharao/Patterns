using System.Collections;

namespace Iterator_Pattern
{
    class Collection : IAggregate
    {
        private readonly ArrayList _items = new ArrayList();

        /// <summary>
        /// Indexer for the collection
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }

        /// <summary>
        ///  Gets item count
        /// </summary>
        public int Count
        {
            get { return _items.Count; }
        }

        /// <summary>
        /// Creates an iterator
        /// </summary>
        /// <returns>returns an iterator</returns>
        public IIterator CreateIterator()
        {
            return new Iterator(this);
        }
    }
}
