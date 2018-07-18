namespace Mediator_Pattern
{
    /// <summary>
    /// Defines the mediator
    /// </summary>
    interface IMediator
    {
        void Subscribe(IColleague colleague);

        /// <summary>
        /// publishes the message from a colleague to other colleagues
        /// </summary>
        /// <param name="message"></param>
        /// <param name="colleague"></param>
        void PublishMessage(string message, IColleague colleague);
    }
}
