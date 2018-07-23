namespace Observer_Pattern
{
    interface ISubject
    {
        double Price { get; set; }
        void Subscribe(IObserver observer);
        void UnSubscribe(IObserver observer);
        void Update();
    }
}
