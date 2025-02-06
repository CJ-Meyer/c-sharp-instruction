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
            Print("\nWelcome to the Factorial Calculator \n");
            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                int x = 0;
                long total = 1;
                Console.Write("Enter an integer that's greater than 0 and less than 10:");
                try { x = Int32.Parse(Console.ReadLine()); }
                catch { Print("Error: must be a whole number between 0-10"); continue; }

                for (int i = 1; i <= x; i++)
                {
                    total *= i;
                }
                Console.WriteLine("\nThe factorial of " + x + " is " + total + ".\n");
                choice = PromptUser("Continue? (y/n): ");
            }
            //4-3
            choice = "y";
            double com = 0;
            Print("\nWelcome to the tip calculator \n");
            while (choice == "y")
            {
                Print("Cost of meal: " + "\n"); try { com = Double.Parse(Console.ReadLine()); } catch { Print("Error invalid data - Enter any number"); continue; }
                for (double i = .15; i <= .25; i += .05)
                {
                    double TipAmount = Math.Round(com * i, 2);
                    double TotalAmount = Math.Round(TipAmount + com, 2);
                    Print(i.ToString("p0"));
                    Print("Tip amount: " + TipAmount);
                    Print("Total amount: " + TotalAmount + "\n");
                }
                choice = PromptUser("Continue (y/n): ");
            }
            // tip calculator with sean
            choice = "y";
            while (choice == "y"){
                Console.Write("Cost of meal: ");
                //skipping validation
                decimal costOfMeal = Decimal.Parse(Console.ReadLine());
                //prompy costOfMeal: decimal
                //biz logic:
                //-calculate and display tipAmt: deciaml and totalAmt: decimal for .15, .20, .25
                //for decimal d = .15m; d<= .25m; d+=.05m;
                for (decimal d = .15m; d <= .25m; d += .05m)
                {
                    decimal TipAmount1 = Math.Round(costOfMeal * d, 2);
                    decimal TotalAmount1 = Math.Round(TipAmount1 + costOfMeal, 2);
                    Print(d.ToString("p0"));
                    Print("Tip amount: " + TipAmount1.ToString("c"));
                    Print("Total amount: " + TotalAmount1.ToString("c") + "\n");
                }

                Print("Continue? (y/n): ");
                choice = Console.ReadLine().ToLower();
            }


            // factorial with Sean
            Print("welcome to the factorial calculator num 2");
            choice = "y";
            while (choice == "y")
            {
                //{
                //    long theNumber = GetLong("enter an integer that greater than 0 and less than 1000: ", 1, 1000);
                //    long theFactorial = 1;
                //    for (int i = 1;i<= theNumber; i++)
                //    {
                //        theFactorial *= i;
                //    } Print("The factorial of " + theNumber + " is " + theFactorial + ".");
                long theFactorial = 1;
                for (int i = 1;theFactorial>0; i++)
                {
                    theFactorial *= i;
                    Console.WriteLine("i: "+i+", factorial: "+ theFactorial);
                }
                Console.WriteLine("Continue (y/n): ");
                choice = Console.ReadLine().ToLower();
            }


        }

        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        //prompt method
        static string PromptUser(string msg)
        {
            Console.Write(msg); return Console.ReadLine();
        }

        private static void PowerTable()
        {
            Print("Welcome to the Squares and Cubes table !\n");
            string choice = "y";
            while (choice == "y" || choice == "Y")
            {
                int num = Int32.Parse(GetInt("Enter an integer: "));
                Console.WriteLine("\n{0,-10}{1,-10}{2,-10}", "Number", "Squared", "Cubed");
                Console.WriteLine("{0,-10}{1,-10}{2,-10}", "======", "=======", "=====");

                for (int i = 1; i <= num; i++)
                {
                    Console.WriteLine($"{i,-9} {i * i,-9} {i * i * i,-10}");
                }
                choice = PromptUser("\nContinue? (y/n): ");
            }
        }
        private static long GetLong(string prompt, long min, long max)
        {
            long result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Console.Write(prompt);
                if (!long.TryParse(Console.ReadLine(), out result))
                { 
                    Console.WriteLine("Error - invalid whole number. Try again."); continue;
                }
                if (result < min || result > max)
                {
                    Console.WriteLine("Error - input must be within range ("+min+"-"+max+"). Try again.");
                } else { isValid  = true;
                }
            }
            return result;
        }
        static string GetInt(string msg)
        {
            Console.Write(msg); return Console.ReadLine();
        }
    }
}
