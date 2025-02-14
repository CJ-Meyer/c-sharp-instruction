using ConsoleLibrary;
using GuessingGame;
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
                Game.DisplayResults(die1, die2, total);
                MyConsole.PrintLine("");
                x = PromptChoice("Roll again? (y/n): ");
                MyConsole.PrintLine("");
            }


            // Guess the number game
            MyConsole.PrintLine("Welcome to the Guess the Number Game");
            MyConsole.PrintLine("");
            MyConsole.PrintLine("++++++++++++++++++++++++++++++++++++");
            MyConsole.PrintLine("");
            int counter = 0;
            string choice = "y";
            //start while loop here 
            while (choice == "y")
            {
                int randNum = 0;
                int Guess = 0;
                GameReset(out x, rand, out counter, out randNum);
                while (x != "y")
                {
                    Guess = MyConsole.PromptInt("Enter an integer between 1 and 100: "); 
                    if (Guess < 0 || Guess >= 100)
                    {
                        MyConsole.PrintLine("Error: entry must be within 1 and 100");
                        continue;
                    }
                    GuessCheck(ref x, ref counter, randNum, Guess);

                }
                choice = MyConsole.PromptReqString("try again? (y/n): ", "y", "n");
            }
            MyConsole.PrintLine("Bye");
        }
        // start methods

        // Celebration method
        
        // game reset method
        private static void GameReset(out string x, Random rand, out int counter, out int randNum)
        {
            counter = 0;
            x = "a";
            MyConsole.PrintLine("I'm thinking of a number from 1 to 100.");
            MyConsole.PrintLine("Try to guess it.");
            MyConsole.PrintLine("");
            randNum = BigNum(rand);
        }
        // check guess method
        private static void GuessCheck(ref string x, ref int counter, int randNum, int Guess)
        {
            if (Guess == randNum)
            {
                counter++;
                MyConsole.PrintLine("Great work");
                MyConsole.PrintLine("You got it in " + counter + " tries");
                x = "y";
                Game.resultMsg(counter);

            }
            else if (Guess > randNum)
            {
                if (Math.Abs(Guess - randNum) >= 10)
                {
                    MyConsole.PrintLine("way too high");
                    counter++;
                }
                else if (Math.Abs(Guess - randNum) < 10) { MyConsole.PrintLine("too high"); counter++; }
            }
            else
            {
                if (Math.Abs(Guess - randNum) >= 10)
                {
                    MyConsole.PrintLine("Way too low"); counter++;
                }
                else if (Math.Abs(Guess - randNum) < 10) { counter++; MyConsole.PrintLine("too low"); }
            }
        }

        static string PromptChoice(string prompt)
        {
            Console.Write(prompt);
            return Console.ReadLine().ToLower();
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
