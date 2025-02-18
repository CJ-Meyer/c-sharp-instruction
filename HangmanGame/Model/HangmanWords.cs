using ConsoleLibrary;

namespace HangmanGame.Model
{
    internal class HangmanWords
    {
        public string hiddenWord = "";
        public string selectedWord = "";
        Random random = new Random();
        private List<string> words = new List<string>();
        public HangmanWords() {
            words.Add("Hello");
            words.Add("Indigo");
            words.Add("Wano");
            words.Add("Hazard");
            words.Add("Meat");
            words.Add("ZORO");
        }
        public string GetrandomWord() {
            selectedWord = words[random.Next(words.Count)];
            return selectedWord ;
        }
        public string GetHiddenWord(string randomWord)
        {
            
            hiddenWord = new string ('_', selectedWord.Length);
            return hiddenWord ;
        }
        public void DisplayHiddenWord(string word)
        {
           MyConsole.PrintLine(string.Join(" ", hiddenWord.ToCharArray()));
        }
    }
}
