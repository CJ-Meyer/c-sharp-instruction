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
                
                string hidden = hang.GetHiddenWord(randomWord);
                List<char> lettersGuessed = new List<char>();
                while (incorrectGuesses != 6 && !wordGuessed)
                {
                    MyConsole.PrintLine(GetHangmanImage(incorrectGuesses));
                    Console.Write("Hint: ");
                    DisplayHiddenWord(hidden);
                    string letterGuessed = (MyConsole.PromptString("Guess a letter in the word: "));
                    MyConsole.PrintLine($"Letter guessed: {letterGuessed}");
                    
                    // compare the guessed letter to the word
                    // iterate over randomWord and find any matches for letter
                    
                    char[] charsWord = randomWord.ToCharArray();
                    char[] charsHidden = hidden.ToCharArray();
                    for (int i = 0; i < charsWord.Length; i++)
                    {
                        char c = charsWord[i];
                        if (letterGuessed == c.ToString()) {
                            charsHidden[i] = c;
                            MyConsole.PrintLine($"letter matched at index: {i}"); 
                        }
                    }
                    

                    hidden = new string(charsHidden);
                    DisplayHiddenWord(hidden);
                    if(hidden.IndexOf("_") == -1)
                    {
                        wordGuessed = true;
                    }



                    // if guessed letter in word 
                    //      reveal all letter locations 
                    //          remove underscore at index and insert letter into DisplayHiddenWord

                    //      if word is guessed wordGuessed = true;
                    // if guessed letter not in the word 
                    //  increment the incorrectGuess count
                    // if the count is 6
                    //  the user loses


                    //


                }
                choice = MyConsole.PromptReqString("Continue? (y/n): ", "y", "n");
            }

            MyConsole.PrintLine("BYE!");

        }

        private static void DisplayHiddenWord(string hidden)
        {
            //display hidden word with a space afterwards
            MyConsole.PrintLine("display hiddenWord");
            foreach (char c in hidden)
            {
                Console.Write(c + " ");
            }
            MyConsole.PrintLine();
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

