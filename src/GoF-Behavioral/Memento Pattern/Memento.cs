namespace Memento_Pattern
{
    /// <summary>
    /// generic Memento
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class Memento<T>
    {
        public T State { get; set; }

        public Memento(T state)
        {
            this.State = state;
        }

        public override string ToString()
        {
            return State.ToString();
        }
    }
}
