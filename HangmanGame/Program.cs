using System.Reflection.Metadata.Ecma335;
using ConsoleLibrary;

namespace HangmanGame
{
    internal class Program
    {
        static string[] images = new string[7];
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the hangman\n");
            string player1 = "";
            PromptPlayerName(out player1);
            PopulateImages();
            for (int i = 0; i < images.Length; i++) {
                MyConsole.PrintLine($"images{i}");
                MyConsole.PrintLine(images[i]);
                MyConsole.PrintLine("==========");
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
        private static void PromptPlayerName(out string player1)
        {
            player1 = MyConsole.PromptString("player 1, enter Name:");
        }

        

    }
}

