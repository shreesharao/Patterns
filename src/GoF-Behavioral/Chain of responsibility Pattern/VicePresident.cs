namespace Chain_of_responsibility_Pattern
{
    class VicePresident : IHandler
    {
        public IHandler Successor { get; set; }

        public bool HandleRequest(IRequest request)
        {
            if (request.LoanAmount <= 50000)
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
            this.Successor = successor;
        }
    }
}
