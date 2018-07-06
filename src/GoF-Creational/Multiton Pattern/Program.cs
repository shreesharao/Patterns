using System;

namespace Multiton_Pattern
{
    static class Program
    {
        static void Main(string[] args)
        {
            PolicyManager policyManager = new PolicyManager();
            var policy = policyManager.GetPolicy("Car");
            Console.WriteLine($"{policy.PolicyType}:{policy.Id}");

            policy = policyManager.GetPolicy("Car");
            Console.WriteLine($"{policy.PolicyType}:{policy.Id}");

            policy = policyManager.GetPolicy("Bike");
            Console.WriteLine($"{policy.PolicyType}:{policy.Id}");
            Console.Read();
        }
    }
}
