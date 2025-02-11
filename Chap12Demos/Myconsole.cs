namespace Chap12ContactList
{
    internal class MyConsole {
        public static int PromptInt(string text)
        {
            int result = 0; bool isValid = false;
            while (isValid == false)
            {
                Print(text);
                if (isValid = int.TryParse(Console.ReadLine(), out result))
                {
                    isValid = true;
                }
                else
                {
                    PrintLine("Invalid input. Please enter a valid integer.");

                }
            }
            return result;
        }
        public static string PromptString(string prompt) { Print(prompt); return Console.ReadLine(); }
        public static void Print(string msg)
        {
            Console.Write(msg);
        }
        public static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
