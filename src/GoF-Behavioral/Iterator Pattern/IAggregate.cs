namespace Iterator_Pattern
{
    interface IAggregate
    {
        object this[int index]
        {
            get;
            set;
        }

        int Count { get;}
        IIterator CreateIterator();
    }
}
