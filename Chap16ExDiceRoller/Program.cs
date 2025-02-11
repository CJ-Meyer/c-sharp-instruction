using ConsoleLibrary;
namespace Chap16ExDiceRoller
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the Dice Roller!");

            string choice = MyConsole.PromptString("roll the dice? (y/n): ").ToLower();
            while (choice == "y") { 
            Dice dice = new Dice();
                dice.roll();
                MyConsole.PrintLine(dice.GetRollResults());
                choice = MyConsole.PromptString("roll again? (y/n): ").ToLower();
            }
            
            MyConsole.PrintLine("BYE!");
        }
    }
}
