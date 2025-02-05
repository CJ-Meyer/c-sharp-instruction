using System.Diagnostics.Metrics;
using System.Globalization;
using Microsoft.VisualBasic;

namespace projects_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Dice roll game
            string x = PromptChoice("Roll the dice? (y/n): ");
            Random rand = new Random();
            while (x == "y")
            {
                int die1 = DiceRoll(rand);
                int die2 = DiceRoll(rand);
                int total = die1 + die2;
                DisplayResults(die1, die2, total);
                Print("");
                x = PromptChoice("Roll again? (y/n): ");
                Print("");
            }


            // Guess the number game
            Print("Welcome to the Guess the Number Game");
            Print("++++++++++++++++++++++++++++++++++++");
            int counter = 0;
            string choice = "y";
            //start while loop here 
            while (choice == "y")
            {
                counter = 0;
                x = "a";
                Print("I'm thinking of a number from 1 to 100.");
                Print("Try to guess it.");
                int randNum = BigNum(rand);
                while (x != "y")
                {
                    Print("Enter number: "); int Guess = Int32.Parse(Console.ReadLine());
                    if (Guess == randNum)
                    {
                        counter++;
                        Print("Great work");
                        Print("You got it in " + counter + " tries");
                        x = "y";

                    }
                    else if (Guess > randNum)
                    {
                        if (Math.Abs(Guess - randNum) >= 10)
                        {
                            Print("way too high");
                            counter++;
                        }
                        else if (Math.Abs(Guess - randNum) < 10) { Print("too high"); counter++; }
                    }
                    else
                    {
                        if (Math.Abs(Guess - randNum) >= 10)
                        {
                            Print("Way too low"); counter++;
                        }
                        else if (Math.Abs(Guess - randNum) < 10) { counter++; Print("too low"); }
                    }

                }
                choice = PromptChoice("try again? (y/n): ");
            }
            Print("Bye");
        }

        static string PromptChoice(string prompt)
        {
            Print(prompt);
            return Console.ReadLine().ToLower();
        }

        private static void DisplayResults(int die1, int die2, int total)
        {
            Print("Roll 1: " + die1);
            Print("Roll 2: " + die2);
            Print("Total: " + total);
            if (die1 == 1 && die2 == 1)
            {
                Print("Snake eyes!");
            }
            else if (die1 == 6 && die2 == 6)
            {
                Print("Boxcars!");
            }
        }

        // Print method 
        static void Print(string msg)
        {
            Console.WriteLine(msg);
        }
        // Dice roll method
        static int DiceRoll(Random rand)
        {
            return rand.Next(1, 7);
        }

        // random num 1-100
        static int BigNum(Random rand)
        {
            return rand.Next(1, 100);
        }

    }
}
