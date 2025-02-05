using Microsoft.VisualBasic;

namespace Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //4-1
            
            PowerTable();

            //4-2
            Print("Welcome to the Factorial Calculator");
            string choice = "y";
            while (choice == "y")
            {
                int x = 0;
                long total = 1;
                Console.Write("Enter an integer that's greater than 0 and less than 10:");
                try{x = Int32.Parse(Console.ReadLine()); }
                catch { Print("Error: must be a whole number between 0-10");continue; }

                for (int i = 1; i <= x; i++)
                {
                    total *= i;
                }
                Console.WriteLine("The factorial of "+x+" is "+total+".");
                choice = Prompt("Continue? (y/n): ");
            }
            //4-3
            choice = "y";
            Print("Welcome to the tip calculator");
            while (choice == "y")
            {
                Print("Cost of meal: "); double com = Double.Parse(Console.ReadLine());
                double TipAmount15 = Math.Round(com * .15, 2);
                double TotalAmount15 = Math.Round(TipAmount15 + com, 2);
                Print("15%");
                Print("Tip amount: "+TipAmount15);
                Print("Total amount: "+ TotalAmount15);
                choice = Prompt("Continue (y/n): ");
            }
        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        //prompt method
        static string Prompt(string msg)
        {
            Console.Write(msg); return Console.ReadLine();
        }

        private static void PowerTable()
        {
            Print("Welcome to the Squares and Cubes table !");
            string choice = "y";
            int num = Int32.Parse(GetInt("Enter an integer: "));
            Console.WriteLine("\n{0,-10}{1,-10}{2,-10}", "Number", "Squared", "Cubed");
            Console.WriteLine("{0,-10}{1,-10}{2,-10}", "======", "=======", "=====");

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"{i,-9} {i * i,-9} {i * i * i,-10}");
            }
        }
        static string GetInt(string msg)
        {
            Console.Write(msg); return Console.ReadLine();
        }
    }
}
