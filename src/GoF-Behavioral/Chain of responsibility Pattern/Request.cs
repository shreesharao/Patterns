namespace Chain_of_responsibility_Pattern
{
    class Request : IRequest
    {
        public double LoanAmount { get; set; }
        public bool IsApproved { get; set; }
    }
}
