using ConsoleLibrary;
namespace PigDice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to pig dice game ");
            //Sample output: 
            //# of times to play?:  5 
            //Here we go…. 
            //Played 5 games
            //Highest Score is 82
            //Again? N
            string choice = "y";
            while (choice == "y")
            {
                int numberOfGames = MyConsole.PromptInt("# of times to play?: ");
                int highestScore = 0;
                for (int i = 0; i < numberOfGames; i++)
                {
                    Game game = new Game();
                    game.Play();
                    if (game.Score > highestScore)
                    {
                        highestScore = game.Score;
                    }
                }
                MyConsole.PrintLine($"Played {numberOfGames} games");
                MyConsole.PrintLine($"Highest Score is {highestScore}");
                choice = MyConsole.PromptString("Again? y/n: ").ToLower().Trim() ;
            }
        }
    }
}
