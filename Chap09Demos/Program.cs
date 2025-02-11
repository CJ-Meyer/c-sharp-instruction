using System.Text;

namespace Chap09Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("Welcome to strings and Dates!");
            // p.275
            // whats the current date and time?
            DateTime currentDateTime = DateTime.Now;
            // whats the current date?
            DateTime Today = DateTime.Today;

            //string interpolation
            PrintLine($"Current Date and Time: {currentDateTime}");
            PrintLine($"Current Date: {Today}");

            // p.277
            // date and time formatting
            PrintLine($"Long Date String: {currentDateTime.ToLongDateString()}");
            PrintLine($"Long Time String: {currentDateTime.ToLongTimeString()}");
            PrintLine($"Short Date String: {currentDateTime.ToShortDateString()}");
            PrintLine($"Short Time String: {currentDateTime.ToShortTimeString()}");

            // p.279 get information from a date
            PrintLine($"Month: {currentDateTime.Month}");
            PrintLine($"Day: {currentDateTime.Day}");
            PrintLine($"Year: {currentDateTime.Year}");
            PrintLine($"Hour of the Day: {currentDateTime.Hour}");
            PrintLine($"Minute of the Hour: {currentDateTime.Minute}");
            PrintLine($"Second of the Minute: {currentDateTime.Second}");
            PrintLine($"Millisecond of the Second: {currentDateTime.Millisecond}");
            PrintLine($"Day of the Week: {currentDateTime.DayOfWeek}");
            PrintLine($"Day of the Year: {currentDateTime.DayOfYear}");
            PrintLine($"Kind: {currentDateTime.Kind}");
            PrintLine($"Ticks: {currentDateTime.Ticks}");
            PrintLine($"Time of Day: {currentDateTime.TimeOfDay}");
            PrintLine($"Is Daylight Savings Time: {currentDateTime.IsDaylightSavingTime()}");
            PrintLine($"Is Leap Year: {DateTime.IsLeapYear(currentDateTime.Year)}");
            PrintLine($"Is Leap Year: {DateTime.IsLeapYear(2024)}");
            PrintLine($"Is Leap Year: {DateTime.IsLeapYear(2025)}");
            PrintLine($"Is Leap Year: {DateTime.IsLeapYear(2026)}");

            // p.281 manipulating dates and times
            //due date in 2 months:
            DateTime dueDate = currentDateTime.AddMonths(2);
            PrintLine($"Due Date: {dueDate}");

            // Halloween 2025
            DateTime halloween = new DateTime(2025, 10, 31);
            PrintLine($"Halloween 2025: {halloween}");

            PrintLine($"Halloween > Today? {halloween > Today}");
            TimeSpan timeToHalloween = halloween - Today;
            PrintLine($"Time to Halloween: {timeToHalloween.Days}");

            // p.285 Strings
            // loop through characters in a string
            string message = "Hello, World!";
            foreach (char c in message)
            {
                Print(c + " ");
            } PrintLine("");

            // hangman - creating underscore version of a word
            // word is "spiderman", the hiddenVersion would be "_ _ _ _ _ _ _ _ _"
            string word = "spiderman";
            string hiddenVersion = "";
            foreach (char c in word)
            {
                if (c == ' ')
                {
                    hiddenVersion += " ";
                }
                else
                {
                    hiddenVersion += "_";
                }
                hiddenVersion += " ";
                
            }PrintLine($"The word is {word}");
                PrintLine($"The hidden version is {hiddenVersion}");

            // p.293
            StringBuilder sb = new StringBuilder();
            sb.Append("Hello, ");
            sb.Append("New, ");
            sb.Append("World!");
            PrintLine(sb.ToString());


            PrintLine("goodBYE!");
        }
        //print method
        static void Print(string message)
        {
            Console.Write(message);
        }

        //printLine method
        static void PrintLine(string message)
        {
            Console.WriteLine(message);
        }
    }
}
