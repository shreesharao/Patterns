using System;

namespace Multiton_Pattern
{
    class Policy
    {
        public string PolicyType { get; set; }
        public Guid Id { get; set; }
        public Policy(string policyType)
        {
            this.Id = Guid.NewGuid();
            this.PolicyType = policyType;
        }
    }
}
