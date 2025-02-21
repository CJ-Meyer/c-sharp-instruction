using System.Collections;
using ConsoleLibrary;

namespace WheelOfFortune
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Wheel Of Fortune!!!");
            WordsAndPhrases wp = new WordsAndPhrases();
            // Point of the game is to make as much money as you can while guessing letters to make up a word or phrase
            // A hint is shared with players at the beginning 
            string randomWord = wp.GetrandomWord();
            string hiddenWord = wp.GetHiddenWord(randomWord);
            string displayWord = wp.DisplayHiddenWord(hiddenWord);
            MyConsole.PrintLine(randomWord);
            MyConsole.PrintLine(displayWord);

            // GamePlan and questions
            // How are you storing the word or phrase selection? How are you storing the 'blanks' version?
            // Store words/phrases in 

            // How are you maintaining the player's bank?
            // maintain the player to bank index using a Dictionary?

            // What does the logic look like for managing a round?

            // What does the logic look like for buying a vowel?

            // How are you running the game overall?
        }
    }
}
