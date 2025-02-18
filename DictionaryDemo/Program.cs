using ConsoleLibrary;

namespace DictionaryDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Hello, World!");

            Dictionary<string, string> usStates = new Dictionary<string, string>();
            // throws an exception if it exists
            usStates["IN"] = "Indiana";
            usStates["OH"] = "Ohio";
            // [] Indexer - sets this postion in the dictionary, replaces entry if it already exists
            MyConsole.PrintLine("enter some US States. Enter EX to exit");
            MyConsole.PrintLine("======================================");
            string stateAbbreviation = "";
            while (stateAbbreviation != "EX")
            {
                stateAbbreviation = MyConsole.PromptString("US State Abbreviation: ").ToUpper();
                if (stateAbbreviation == "EX")
                    break;
                string stateName = MyConsole.PromptString("State Name: ");
                usStates [stateAbbreviation] = stateName;
                // store in a dictionary
            }

            MyConsole.PrintLine("Get states: ");
            MyConsole.PrintLine($"Key 'OH' = {usStates["OH"]}");

            MyConsole.PrintLine("\nDisplay all keys: ");
            foreach (string s in usStates.Keys) {
                MyConsole.Print($"{s}, ");
            }

            MyConsole.PrintLine("\nDisplay all values: ");
            foreach (string s in usStates.Values)
            {
                MyConsole.Print($"{s}, ");
            }

            MyConsole.PrintLine("\nKey Value Pair");
            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.Print($"Key: {entry.Key}- Value: {entry.Value}, ");
            }

            MyConsole.PrintLine("Remove an entry\n");
            usStates.Remove("OH");
            foreach (KeyValuePair<string, string> entry in usStates)
            {
                MyConsole.Print($"Key: {entry.Key}- Value: {entry.Value}, ");
            }



            MyConsole.PrintLine("\nBYE!");
        }
    }
}
