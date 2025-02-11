namespace Chap12ContactList
{
    internal class Contact
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public Contact(string FirstName, string LastName, string Email, string Phone)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.Phone = Phone;
        }

        public string DisplayContact() { 
            string displayStr = "---------------------------------------------\n";
            displayStr += "---------------Current Contact---------------\n";
            displayStr += "---------------------------------------------\n";
            displayStr += $"Name:                 {FirstName} {LastName}\n";
            displayStr += $"Email:                {Email}\n";
            displayStr += $"Phone:                {Phone}\n";
            displayStr += "---------------------------------------------\n";
            return displayStr;
        }
    }
}
