namespace Mediator_Pattern
{
    /// <summary>
    /// Defines the structure for Colleagues
    /// </summary>
    interface IColleague
    {
        string Name { get; set; }
        IMediator Mediator { get; set; }
        void Listen(string message, IColleague colleague);
        void Say(string message);
    }
}
