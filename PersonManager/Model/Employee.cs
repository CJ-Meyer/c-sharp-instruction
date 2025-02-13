namespace PersonManager.Model
{
    internal class Employee : Person
    {
        public string Ssn { get; set; }
        public Employee(string firstName, string lastName, string Ssn) : base(firstName, lastName)
        {
            this.Ssn = Ssn;
                }
        public override string ToString()
        {
            string ssnMasked = "xxx-xx-" + Ssn.Substring(7);
            return $"{base.ToString()}SSN: {ssnMasked}";
        }
    }
}

