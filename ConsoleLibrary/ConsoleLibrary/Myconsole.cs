namespace ConsoleLibrary
{
    public class MyConsole {
        public static double PromptDouble(string prompt)
        {
            double result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Double.TryParse(Console.ReadLine(), out result))
                {
                    isValid = true;
                }
                else
                {
                    PrintLine("Error - invalid double.");
                }
            }

            return result;
        }
        public static decimal PromptDecimal(string prompt)
        {
            decimal result = 0m;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                if (Decimal.TryParse(Console.ReadLine(), out result))
                {
                    isValid = true;
                }
                else
                {
                    PrintLine("Error - invalid decimal.");
                }
            }
            return result;
        }
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

        public static string PromptReqString(string prompt, string str1, string str2)
        {
            while (true)
            {
                Console.Write(prompt + " ");
                string recorded = Console.ReadLine();

                if (recorded == str1 || recorded == str2)
                {
                    return recorded;
                }

                Console.WriteLine("Error: invalid input, try again.");
            }
        }

        public static string PromptString(string prompt) { Print(prompt); return Console.ReadLine(); }
        
        public static void Print(string msg)
        {
            Console.Write(msg);
        }
        
        public static void PrintLine(string msg = "")
        {
            Console.WriteLine(msg);
        }
    }
}
