using ConsoleLibrary;

namespace HangmanGame.Model
{
    internal class HangmanWords
    {
        private string hiddenWord = "";
        public string selectedWord = "";
        Random random = new Random();
        private List<string> words = new List<string>();
        public HangmanWords() {
            words.Add("hello");
            words.Add("indigo");
            words.Add("wano");
            words.Add("hazard");
            words.Add("meat");
            words.Add("zoro");
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
    }
}
