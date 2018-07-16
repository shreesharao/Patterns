namespace Chain_of_responsibility_Pattern
{
    class President : IHandler
    {
        public IHandler Successor { get; set; }

        public bool HandleRequest(IRequest request)
        {
            if (request.LoanAmount <= 100000)
            {
                request.IsApproved = true;
            }
            else
            {
                request.IsApproved = false;
                Successor?.HandleRequest(request);
            }
            return request.IsApproved;
        }

        public void SetSuccessor(IHandler successor)
        {
            Successor = successor;
        }
    }
}
