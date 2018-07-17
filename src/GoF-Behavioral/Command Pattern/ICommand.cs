namespace Command_Pattern
{
    interface ICommand
    {
        /// <summary>
        /// Executes the action
        /// </summary>
        void Execute();

        /// <summary>
        /// rolls back the action executed
        /// </summary>
        void Rollback();
    }
}
