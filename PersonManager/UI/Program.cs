using ConsoleLibrary;
using PersonManager.Model;
namespace PersonManager.UI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the person Manager!");
            string choice = "y";
            while (choice == "y")
            {
                string personType = MyConsole.PromptReqString("\nCreate customer or employee? (c/e): ", "c", "e");
                string firstName = MyConsole.PromptString("First name: ");
                string lastName = MyConsole.PromptString("Last name: ");
                Person p;
                if (personType == "c")
                {
                    string customerNumber = MyConsole.PromptString("Customer number: ");
                    Customer c = new Customer(firstName, lastName, customerNumber);
                    p = c;
                } else
                {
                    string Ssn = MyConsole.PromptString("SSN: ");
                    Employee e = new Employee(firstName, lastName, Ssn);
                    p = e;
                }
                MyConsole.PrintLine($"\nYou entered a new {p.GetType().Name} -");
                MyConsole.PrintLine(p.ToString());
                //print person summary
                choice = MyConsole.PromptReqString("\nContinue? (y/n)  :", "y", "n");
            }







            Console.WriteLine("BYE!");
        }





    }
}
