using ConsoleLibrary;

namespace Project11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Animal counter!");

            MyConsole.PrintLine("counting alligators ...");
            for (int i = 1; i <= 3; i++)


            MyConsole.PrintLine("\ncounting sheep ...");
            Sheep s = new Sheep();
            s.Name = "Blackie";
            Count(s, 2);


            MyConsole.PrintLine("BYE!");
        }

        //Count method 
        public void Count() { }
    }
}
