namespace Chap12ContactList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the contact list app \n");
            string choice = "y";
            while (choice == "y")
            {
                string firstName = MyConsole.PromptString("Enter first name: ");
                string lastName = MyConsole.PromptString("Enter last name: ");
                string email = MyConsole.PromptString("Enter email: ");
                string phone = MyConsole.PromptString("Enter phone: ");
                // create a contact instance
                Contact contact = new Contact(firstName, lastName, email, phone);
                MyConsole.PrintLine(contact.DisplayContact());
                choice = MyConsole.PromptString("Continue? (y/n): ").ToLower().Trim();
            }
        }
    }
}
