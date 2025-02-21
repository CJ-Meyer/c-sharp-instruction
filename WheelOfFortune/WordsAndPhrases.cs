namespace WheelOfFortune
{
    internal class WordsAndPhrases
    {
        public string hiddenWord = "";
        public string selectedWord = "";
        Random random = new Random();
        private List<string> words = new List<string>();
        public WordsAndPhrases()
        {
            words.Add("Good morning");
            words.Add("indigo");
            words.Add("wano");
            words.Add("hazard punk");
            words.Add("meat the maker");
            words.Add("zoro");
        }
        public string GetrandomWord()
        {
            selectedWord = words[random.Next(words.Count)];
            return selectedWord;
        }
        public string GetHiddenWord(string randomWord)
        {
            hiddenWord = new string('_', selectedWord.Length);
            return hiddenWord;
        }
        public string DisplayHiddenWord(string hiddenWord)
        {
            string result = "";
            foreach (char c in hiddenWord)
            {
                if (c == '_') { continue; }
                else {result += $"{c} ";  }
                
            }
            return result;
        }
    }
}
