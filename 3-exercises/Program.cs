using System.Diagnostics.CodeAnalysis;

namespace _3_exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Chapter 5 Demos");
            // p.139
            int a = 5;
            int b = 5;
            Console.WriteLine(a == b);

            String name1 = "Bob";
            String name2 = "Bob";
            Console.WriteLine(name1 == name2);

            //// p.141 Logical operators
            //// is sky blue and is temp above 74?
            int temp = 76;
            String skyColor = "blue";

            if (skyColor == "blue" && temp > 74)
            {
                Console.WriteLine("blue and above 74");
            }


            // p.143 nest if - traffic light
            // simple r, y, g
            // yellow light rules:
            // dist <20 yards, go
            // dist >=20 <30, speed up
            // dist >=30, slow down
            string choice = "y";
            while (choice == "y")
            {
                Console.WriteLine("Light color? (r, y, g): ");
                string lightColor = Console.ReadLine();
                if (lightColor == "r")
                {
                    Console.WriteLine("stop!");
                }
                else if (lightColor == "y")
                {
                    Console.Write("distance to light (yards?)");
                    int dist = Convert.ToInt32(Console.ReadLine());
                    string msg = "";
                    if (dist < 20)
                    {
                        msg = "Go!";
                    }
                    else if (dist < 30)
                    {
                        msg = "Go, but hurry!! Speed up!";
                    }
                    else
                    {
                        msg = "slow down";
                    }
                    Console.WriteLine(msg);
                }
                else if (lightColor == "g")
                {
                    Console.WriteLine("Go!");
                }
                else
                {
                    Console.WriteLine("Invalid light color: " + lightColor);

                }
                Console.WriteLine("continue? ");
                choice = Console.ReadLine();

                //    // p.145 switch statement 
                //    // CRUD Operations
                Console.WriteLine("Movie Table - which action to perform");
            string action = "";
            while (action != "exit")
            {
                Console.WriteLine("Menu: ");
                Console.WriteLine("=======");
                Console.WriteLine("Get : Get all Movies");
                Console.WriteLine("GID : Get Movie By ID");
                Console.WriteLine("Add : Add Movie");
                Console.WriteLine("Upd : Update Movie");
                Console.WriteLine("Del : Delete Movie");
                Console.WriteLine("Exit : Exit");
                Console.Write("Action: ");
                action = Console.ReadLine().ToLower();

                switch (action)
                {
                    case "get":
                        Console.WriteLine("Get was selected");
                        break;
                    case "gid":
                        Console.WriteLine("GID was selected");
                        break;
                    case "add":
                        Console.WriteLine("Add was selected");
                        break;
                    case "upd":
                        Console.WriteLine("Upd was selected");
                        break;
                    case "del":
                        Console.WriteLine("Del was selected");
                        break;
                    case "exit":
                        break;
                    default:
                        Console.WriteLine("Invalid selection - " + action);
                        break;
                }
            }
            // p. 147 case w/ arrow operators
            // customer type: discountPct
            //"R" - 10%
            //"C" - 20%
            // else - 0%
            string custType = "R";
            decimal discPct = 0.0m;
            discPct = custType switch
            {
                "R" => .1m,
                "C" => .2m,
                _ => .0m
            };
            Console.WriteLine("discPct = " + discPct);

            // p.151 conditional expression / ternary operator
            // day of week :weekday/weekend conversion
            // day is 1-5: weekday, 6 or 7, weekend
            int dow = 4;
            string msg = "";
            if (dow <= 5)
            {
                msg = "weekday";
            }
            else { msg = "weekend"; }
            Console.WriteLine(msg);
            string msg = (dow <= 5) ? "weekday" : "weekend";
            Console.WriteLine(msg);
            // p.155 while loop that adds num 1-4
            int i = 0;
            int sum = 0;
            // sum all values from 0-10
            while (i <= 10)
            {sum += i;
                i++;}
            Console.WriteLine("i = " + i);
            Console.WriteLine("sum = "+sum);
            // while lopp for data validation
            bool success = false;
            int month = 0;
            //prompt user for month until they enter a valid month 
            while (!success)
            {
                Console.WriteLine("Enter month #: ");
                month = Convert.ToInt32(Console.ReadLine());
                if (month < 1 || month > 12)
                {
                    Console.WriteLine("Invalid month # try again");
                }
                else { success = true; }
                Console.WriteLine("Month entered: " + month);
            }
            while (true)
            {
                Console.WriteLine("In a while tru loop...");
                Console.WriteLine("write an even #: ");
                int nbr = Convert.ToInt32(Console.ReadLine());
                if (nbr % 2 == 0) { break; }
            }
            // p.157 for loops
            //sum 0 to 10 with the for loop
            sum = 0;
            for (int j = 0; j < 11; j++)
            {
                sum += j;
            }
            Console.WriteLine("sum = "+sum);

            // count 0 to 100 by 5 
            for (int j = 100;j > 0; j -= 5)
            {
                Console.WriteLine("j: "+ j);
            }


            Console.WriteLine("Bye");
        }
    }
}
