namespace Chain_of_responsibility_Pattern
{
    interface IRequest
    {
        double LoanAmount { get; set; }
        bool IsApproved { get; set; }
    }
}
