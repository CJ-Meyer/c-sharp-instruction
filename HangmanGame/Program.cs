using ConsoleLibrary;
using HangmanGame.Model;

namespace HangmanGame
{
    internal class Program
    {
        static string[] images = new string[7];
        static void Main(string[] args)
        {
            string hiddenWord = "";
            string choice = "y";
            MyConsole.PrintLine("Welcome to the hangman\n");
            MyConsole.PrintLine("Rules: Continue to guess letters until your man is formed and ultimately hung, or you get the word filled correctly.\nWhichever comes first");
            //PromptPlayerName(out player1);
            PopulateImages();
            HangmanWords hang = new HangmanWords();
            while (choice == "y")
            {

                bool wordGuessed = false;
                int incorrectGuesses = 0;
                string randomWord = hang.GetrandomWord();
                MyConsole.PrintLine($"Random word: {randomWord}");
                string hidden = hang.GetHiddenWord(randomWord);
                List<string> lettersGuessed = new List<string>();
                while (incorrectGuesses != 6 && !wordGuessed)
                {
                    MyConsole.PrintLine(GetHangmanImage(incorrectGuesses));
                    Console.Write("Hint: ");
                    hang.DisplayHiddenWord(hidden);
                    string letterGuessed = MyConsole.PromptString("Guess a letter in the word: ");
                    MyConsole.PrintLine($"Letter guessed: {letterGuessed}");
                    
                }
                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n");
            }

            MyConsole.PrintLine("BYE!");

        }
        private static string GetHangmanImage(int incorrectGuesses)
        { return images[incorrectGuesses]; }
        private static void PopulateImages()
        {
            images[0] =
                """
                -----
                |   |
                |   
                |  
                |  
                _______
                """;
            images[1] =
                """
                -----
                |   |
                |   O
                |  
                |  
                _______
                """;
            images[2] =
                """
                -----
                |   |
                |   O
                |  /
                |  
                _______
                """;
            images[3] =
                """
                -----
                |   |
                |   O
                |  /|
                |  
                _______
                """;
            images[4] =
                """
                -----
                |   |
                |   O
                |  /|\
                |  
                _______
                """;
            images[5] =
                """
                -----
                |   |
                |   O
                |  /|\
                |  /
                _______
                """;
            images[6] =
                """
                -----
                |   |
                |   O
                |  /|\
                |  / \
                _______
                """;
            

        }
    }
}

