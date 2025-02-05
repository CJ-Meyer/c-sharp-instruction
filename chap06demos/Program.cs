namespace chap06demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Print("Welcome to chapter 6 DEMOS!");
            //get info for a movie(title, year, rating, director)
            string choice = "y";
            while (choice == "y")
            {
                string title = GetString("Enter movie title: ");
                int year = GetInt("Enter release year: ", 1900, 2050);
                string rating = GetString("Enter age rating: ");
                string director = GetString("Enter director: ");
                //Validate y or n 

                choice = GetString("Continue? (y/n): ", "y", "n");
            }


            Print("BYE!");
        }
        // GetString Method: accepts aprompt, returns a string from the console
        static string GetString(string prompt)
        {
            Print(prompt, "");
            return Console.ReadLine();
        }
        static string GetString(string prompt, string str1, string str2)
        {
            string retStr = "";
            bool success = false;
            while (!success)
            {
                retStr = GetString(prompt);
                if (retStr.ToLower() == str1 || retStr.ToLower() == str2)
                {
                    success = true;
                }else { Print("error: Entry must be either " + str1 + "or" + str2 + ". Try again"); }

            }
            return retStr;
        }
        static int GetInt(string prompt)
        {
            Print(prompt, "");
            return Int32.Parse(Console.ReadLine());
        }
        static int GetInt(string prompt, int min, int max)
        {
            bool success = false;
            int nbr = 0;
            while (!success)
            {
                Print(prompt, "");
                nbr = Int32.Parse(Console.ReadLine());
                if (nbr < min || nbr > max)
                {
                    Print("Error: out of range. Try again.");
                }
                else { success = true; }
            }
            return nbr;
        }

        // Method accepts one input variable, returns void (no return value)
        static void Print(string msg, string endLine = "\n")
        {
            Console.Write(msg+endLine);
        }
    }
}
