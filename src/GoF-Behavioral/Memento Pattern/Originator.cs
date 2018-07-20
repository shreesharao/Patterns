using System;

namespace Memento_Pattern
{
    class Originator<T>
    {
        private T _state;

        /// <summary>
        /// Handler for event when Memento is changed.
        /// </summary>
        private event EventHandler<MementoChangedEventArgs<T>> MementoChanged;

        public Originator()
        {
            MementoChanged += OnMementoChanged;
        }

        /// <summary>
        /// Creates a new Memento instance using _state.
        /// </summary>
        /// <returns>Newly generated Memento instance.</returns>
        public Memento<T> CreateMemento()
        {
            // Create memento and set state to current state.
            var memento = new Memento<T>(_state);

            //// Invoke event handler.
            MementoChanged?.Invoke(this, new MementoChangedEventArgs<T>
            {
                Memento = memento,
            });
            
            return memento;
        }

        /// <summary>
        /// Set current state based on passed Memento.State property.
        /// </summary>
        /// <param name="memento">Memento from which to get State property.</param>
        public void SetMemento(Memento<T> memento)
        {
            _state = memento.State;

            //// Invoke event handler.
            MementoChanged?.Invoke(this, new MementoChangedEventArgs<T>
            {
                Memento = memento,
            });
        }

        /// <summary>
        /// Explicitly set the state property.
        /// </summary>
        /// <param name="state">State object to set.</param>
        public void SetState(T state)
        {
            _state = state;
        }

        /// <summary>
        /// Fires when Memento is changed.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e">Event args containing Memento instance.</param>
        private void OnMementoChanged(object sender, MementoChangedEventArgs<T> e)
        {
            
            // Output log message with changed Memento.
            Console.WriteLine("--------------MEMENTO CHANGED---------------");
            Console.WriteLine(e.Memento.ToString());
        }

    }
}
