using System;

namespace Chain_of_responsibility_Pattern
{
   static class Program
    {
        static void Main(string[] args)
        {
            IHandler president = new President();
            IHandler vicePresident = new VicePresident();
            IHandler director = new Director();

            //define the chain of responsibility
            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            IRequest request = new Request();
            request.LoanAmount = 10000;

            //caller is not aware who is handling the request. thus decoupling sender and receiver
            var isApproved=director.HandleRequest(request);

            Console.WriteLine($"Loan Amount:{request.LoanAmount} Approved? {isApproved}");

            IRequest anotherRequest = new Request();
            anotherRequest.LoanAmount = 1000000;

            isApproved = director.HandleRequest(anotherRequest);


            Console.WriteLine($"Loan Amount:{anotherRequest.LoanAmount} Approved? {isApproved}");

            Console.Read();
        }
    }
}
