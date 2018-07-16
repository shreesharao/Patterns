namespace Chain_of_responsibility_Pattern
{
    interface IHandler
    {
        /// <summary>
        /// holds the successor information
        /// </summary>
        IHandler Successor { get; set; }

        /// <summary>
        /// sets the successor
        /// </summary>
        /// <param name="successor"></param>
        /// 
        void SetSuccessor(IHandler successor);

        /// <summary>
        /// Handles the request
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        bool HandleRequest(IRequest request);
    }
}
