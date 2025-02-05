using System.ComponentModel.DataAnnotations;
using System.Transactions;

namespace _3_project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //3 - 1 Temp Converter
            Console.WriteLine("Welcome to the Temperature Converter");
            string choice = "y";
            while (choice == "y")
            {
                Console.Write("Enter degrees in Fahrenheit: ");
                double fahrenheit = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine(fahrenheit);
                double celcius = Math.Round((fahrenheit - 32) * (5.0 / 9.0), 2);
                Console.WriteLine("Degrees in celcius: " + celcius);
                Console.WriteLine("Continue? (y/n):  ");
                choice = Console.ReadLine().ToLower();
            }

            //3 - 2
            Console.WriteLine("Welcome to the travel time calculator");
            string choice1 = "y";
            while (choice1 == "y")
            {
                Console.WriteLine("Enter miles: "); double miles = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Enter miles per hour"); double mph = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Estimated travel time");
                Console.WriteLine("---------------------");
                double totalHours = miles / mph;
                int hours = (int)totalHours;
                double minutes = Math.Round((totalHours - (double)hours) * 60, 0);
                Console.WriteLine("Hours: " + hours);
                Console.WriteLine("Minutes: " + minutes);
                Console.Write("Continue? (y/n): "); choice1 = Console.ReadLine().ToLower();
            }
                //3 - 2
                //Console.WriteLine("Welcome to the travel time calculator");
                //string choice1 = "y";
                //while (choice1 == "y")
                //{
                //    Console.WriteLine("Enter miles: "); double miles = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Enter miles per hour"); double mph = Convert.ToDouble(Console.ReadLine());
                //    Console.WriteLine("Estimated travel time");
                //    Console.WriteLine("---------------------");
                //    double totalHours = miles / mph;
                //    int hours = (int)totalHours;
                //    double minutes = Math.Round(((miles % mph)/mph) * 60, 0);
                //    Console.WriteLine("Hours: " + hours);
                //    Console.WriteLine("Minutes: " + minutes);
                //    Console.Write("Continue? (y/n): "); choice1 = Console.ReadLine().ToLower();
                //}
            //3-3
            Console.WriteLine("Welcome to the Interest Calculator");
            choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Enter Loan amount: "); decimal loanAmnt = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Enter Interest Rate"); decimal intRate = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine("Loan amount: " + loanAmnt.ToString("c"));
                Console.WriteLine("Interest rate: " + intRate.ToString("p3"));
                decimal interest = loanAmnt * intRate;
                Console.WriteLine(interest.ToString("c"));
                Console.WriteLine("Continue? (y/n): "); choice = Console.ReadLine();
            }
            // 3-4 with module operator
            Console.WriteLine("Welcome to the change calculator");
            choice = "y";
            int quarters = 0;
            int dimes = 0;
            int nickels = 0;
            int pennies = 0;
            Console.WriteLine("Enter change amount"); int cents = Convert.ToInt32(Console.ReadLine());
            while (choice == "y")
            {
                if (cents >= 25)
                {
                    quarters = cents / 25;
                    cents %= 25;
                    continue;
                }
                else if (cents >= 10)
                {
                    dimes = cents / 10;
                    cents %= 10;
                    continue;
                }
                else if (cents >= 5)
                {
                    nickels = cents / 5;
                    cents %= 5;
                    continue;
                }
                else if (cents >= 1)
                {
                    pennies = cents / 1;
                }
                Console.WriteLine("quarters: "+quarters); quarters = 0;
                Console.WriteLine("dimes: "+dimes); dimes = 0;
                Console.WriteLine("nickels: "+nickels); nickels = 0;
                Console.WriteLine("pennies: " + pennies); pennies = 0;
                Console.WriteLine("Continue ? (y/n): "); choice = Console.ReadLine();
                if (choice == "y")
                {
                    Console.WriteLine("Enter change amount"); cents = Convert.ToInt32(Console.ReadLine());
                }
            }
        }
    }
}