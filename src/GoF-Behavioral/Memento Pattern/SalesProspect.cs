using System;

namespace Memento_Pattern
{
    internal class SalesProspect
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public double Budget { get; set; }

        public SalesProspect(string name, string phone, double budget)
        {
            Name = name;
            Phone = phone;
            Budget = budget;
        }

        public override string ToString()
        {
            return $"Name ={Name} : Phone = {Phone} : Budget = {Budget}";
        }
    }
}