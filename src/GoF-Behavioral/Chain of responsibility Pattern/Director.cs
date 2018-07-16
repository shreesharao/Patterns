using System;

namespace Chain_of_responsibility_Pattern
{
    class Director : IHandler
    {
        public IHandler Successor { get; set; }

        public void SetSuccessor(IHandler successor)
        {
            this.Successor = successor;
        }

        bool IHandler.HandleRequest(IRequest request)
        {
            if(request.LoanAmount<=10000)
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
    }
}
