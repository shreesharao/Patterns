namespace Mediator_Pattern
{
    /// <summary>
    /// Communicates messages between all Persons.
    /// Acts as 'Mediator' within mediator pattern.
    /// </summary>
    class Mediator :IMediator
    {
        /// <summary>
        /// Event handler for MessageReceived event.
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        delegate void MessageReceivedEventHandler(string message, IColleague colleague);

        /// <summary>
        /// MessageReceived event.
        /// </summary>
        event MessageReceivedEventHandler MessageReceived;

        /// <summary>
        /// Publishes the message to all subscribers
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        public void PublishMessage(string message, IColleague colleague)
        {
            MessageReceived?.Invoke(message, colleague);
        }

        /// <summary>
        /// Subscribe to the MessageReceived event
        /// </summary>
        /// <param name="colleague"></param>
        public void Subscribe(IColleague colleague)
        {
            MessageReceived += colleague.Listen;
        }
    }
}
