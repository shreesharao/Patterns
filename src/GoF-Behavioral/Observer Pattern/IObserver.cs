namespace Observer_Pattern
{
    /// <summary>
    /// Defines structure of the observer
    /// </summary>
    interface IObserver
    {
        string Name { get; set; }
        void Update(ISubject subject);
    }
}
