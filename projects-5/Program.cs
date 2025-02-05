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
            Print("");
            Print("++++++++++++++++++++++++++++++++++++");
            Print("");
            int counter = 0;
            string choice = "y";
            //start while loop here 
            while (choice == "y")
            {
                int randNum;
                int Guess;
                GameReset(out x, rand, out counter, out randNum);
                while (x != "y")
                {
                    Console.Write("Enter integer: "); try { Guess = Int32.Parse(Console.ReadLine());} 
                    catch (Exception e) { Print("Error: entry must be a whole number"); continue; }
                    //catch (Exception e)
                    //{
                    //    Print("Error: entry must be a whole number");
                    //    Console.Error.WriteLine("e.Message: "+e.Message);
                    //    Console.Error.WriteLine("e.Message: "+e.ToString());
                    //}
                    if (Guess < 0 || Guess >= 100)
                    {
                        Print("Error: entry must be within 1 and 100");
                        continue;
                    }
                    GuessCheck(ref x, ref counter, randNum, Guess);
                    
                }
                choice = PromptChoice("try again? (y/n): ");
            }
            Print("Bye");
        }
        // start methods

        // Celebration method
        private static void resultMsg(int counter)
        {
            if (counter <= 3)
            {
                Print("Great work! You are a mathematical wizard");
            }
            else if (counter > 3 && counter <= 7)
            {
                Print("Not bad! You've got some potential.");
            }
            else { Print("What took you so long? Maybe you should take some lessons."); }
        }
       // game reset method
        private static void GameReset(out string x, Random rand, out int counter, out int randNum)
        {
            counter = 0;
            x = "a";
            Print("I'm thinking of a number from 1 to 100.");
            Print("Try to guess it.");
            Print("");
            randNum = BigNum(rand);
        }
        // check guess method
        private static void GuessCheck(ref string x, ref int counter, int randNum, int Guess)
        {
            if (Guess == randNum)
            {
                counter++;
                Print("Great work");
                Print("You got it in " + counter + " tries");
                x = "y";
                resultMsg(counter);

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

        static string PromptChoice(string prompt)
        {
           Console.Write(prompt);
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
            return rand.Next(1, 101);
        }

    }
}
