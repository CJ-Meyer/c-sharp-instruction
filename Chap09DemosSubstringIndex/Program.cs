using ConsoleLibrary;

namespace Chap09DemosSubstringIndex
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to index and substring ");

            string letters = "abcdefg";
            string first3 = letters.Substring(0, 3);
            MyConsole.PrintLine($"First 3 {first3}");
            MyConsole.PrintLine($"Next 3 {letters.Substring(3, 3)}");
            MyConsole.PrintLine($"Last {letters.Substring(6, 1)}");


            // first, middle, and last names
            string fullName = "Roberta Nesta Marley";
            // where are the spaces?
            int firstSpace = fullName.IndexOf(" ");
            int secondSpace = fullName.IndexOf(" ", firstSpace+1);
            MyConsole.PrintLine($"First Name: {fullName.Substring(0, firstSpace)}.");
            MyConsole.PrintLine($"Middle Name: {fullName.Substring(firstSpace, secondSpace - firstSpace)}.");
            MyConsole.PrintLine($"Last name: {fullName.Substring(secondSpace)}.");

            // returns -1 if not found 
        }
    }
}
