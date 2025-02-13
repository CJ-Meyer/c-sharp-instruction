namespace PersonManager.Model
{
    internal class Customer : Person
    {
        public string CustomerNumber { get; set; }

        public Customer (string firstName, string lastname, string customerNumber) :
            base(firstName, lastname){
            this.CustomerNumber = customerNumber;
        }
        public override string ToString()
        {
            return $"{base.ToString()}Customer Number: {CustomerNumber}";
        }
    }
}
