namespace Iterator_Pattern
{
    interface IIterator
    {
        Item First();
        Item Next();
        int Step { get; set; }
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
