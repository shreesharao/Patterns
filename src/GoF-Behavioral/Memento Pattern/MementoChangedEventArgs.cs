using System;

namespace Memento_Pattern
{
    public class MementoChangedEventArgs<T> : EventArgs
    {
        internal Memento<T> Memento { get; set; }
    }
}