using ConsoleLibrary;

namespace GuessingGame
{
    public class Game
    {
        public static void DisplayResults(int die1, int die2, int total)
        {
            MyConsole.PrintLine("Roll 1: " + die1);
            MyConsole.PrintLine("Roll 2: " + die2);
            MyConsole.PrintLine("Total: " + total);
            if (die1 == 1 && die2 == 1)
            {
                MyConsole.PrintLine("Snake eyes!");
            }
            else if (die1 == 6 && die2 == 6)
            {
                MyConsole.PrintLine("Boxcars!");
            }
        }
        public static void resultMsg(int counter)
        {
            if (counter <= 3)
            {
                MyConsole.PrintLine("Great work! You are a mathematical wizard");
            }
            else if (counter > 3 && counter <= 7)
            {
                MyConsole.PrintLine("Not bad! You've got some potential.");
            }
            else { MyConsole.PrintLine("What took you so long? Maybe you should take some lessons."); }
        }
    }
}
