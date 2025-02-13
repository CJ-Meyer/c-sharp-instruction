using System.Diagnostics;

namespace Chap15Demos
{
    internal class Customer : Summarizable{
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CustomerNumber { get; set; }

        public Customer(string firstName, string lastName, string customerNumber)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.CustomerNumber = customerNumber;
        }

        public string GetSummaryDetails()
        {
            string summary = $"Customer: ({CustomerNumber}) {LastName}, {FirstName}";
            return summary ;
        }
    }
}
