
using System;
using System.Collections.Generic;
using System.Linq;

namespace Memento_Pattern
{
    class Caretaker<T>
    {
        private readonly List<Memento<T>> _mementoList = new List<Memento<T>>();
        private Originator<T> _originator { get; set; }

        public Caretaker(Originator<T> originator)
        {
            this._originator = originator;
        }

        public Memento<T> Save()
        {
            var memento = _originator.CreateMemento();
            _mementoList.Add(memento);
            return memento;
        }

        /// <summary>
        /// Restore Originator to Memento via passed list index.
        /// </summary>
        /// <param name="index">Index of Memento instance.</param>
        public void Restore(int index)
        {
            // Find match.
            var match = _mementoList[index];

            // Can't restore if not in the list.
            if (match == null)
            {
                throw new ArgumentException($"Memento at index [{index}] not found, cannot restore.");
            }

            // Restore Memento.
            _originator.SetMemento(match);
        }

        /// <summary>
        /// Restore Originator to passed Memento state, if exists.
        /// </summary>
        /// <param name="memento">Memento to be restored to</param>
        public void Restore(Memento<T> memento)
        {
            // Find match.
            var match = _mementoList.FirstOrDefault(x => x == memento);

            // Can't restore if not in the list.
            if (match == null)
            {
                throw new ArgumentException($"Memento [{memento}] not found, cannot restore.");
            }

            // Restore Memento.
            _originator.SetMemento(match);
        }

    }
}
