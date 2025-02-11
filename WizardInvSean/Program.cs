using System.Collections;

namespace WizardInvSean
{
    internal class Program
    {
        static List<string> items = new List<string>();
        static void Main(string[] args)
        {
            PrintLine("Welcome to the wizard inventory game!!!\n");
            items.Add("wooden staff");
            items.Add("wizard hat");
            items.Add("cloth shoes");
            string command = "";
            while (command != "exit")
            {
                DisplayMenu();
                Print("Command: ");
                command = Console.ReadLine().ToLower().Trim();
                switch (command)
                {
                    case "show":
                        ShowItems();
                        break;
                    case "grab":
                        GrabItem();
                        break;
                    case "edit":
                        EditItem();
                        break;
                    case "drop":
                        DropItem();
                        break;
                    case "exit":
                        break;
                }
                PrintLine("");
            }
            PrintLine("BYE");
        }

        private static void DropItem()
        {
            PrintLine("Drop an item");
            PrintLine("------------");
            int itemNumber = PromptInt("Number: ", 1, items.Count);
            string removedItem = items[itemNumber - 1];
            items.RemoveAt(itemNumber - 1);
            PrintLine($"{removedItem} was dropped.");
        }

        private static void EditItem()
        {
            PrintLine("Edit an item");
            PrintLine("--------------");
            int itemNumber = PromptInt("Number: ", 1, items.Count);
            string updatedName = Console.ReadLine(); PrintLine("Updated name: "+ updatedName);
            items[itemNumber - 1] = updatedName;
            PrintLine(" item number " + itemNumber + " was updated.");
        }

        private static void GrabItem()
        {
            PrintLine("Grab an item");
            PrintLine("------------");
            if (items.Count >= 4)
            {
                PrintLine("You can't carry any more items. Drop something first.");
                return;
            }
            else { Print("item to add: ");
                string itemName = Console.ReadLine();
                items.Add(itemName);
                PrintLine($"{itemName} was added.");
            }
            //prompt user for item # to grab
            // add it to the list if list is not full
        }

        private static void ShowItems()
        {
            PrintLine("Show all items");
            PrintLine("--------------");
            for (int i = 0; i < items.Count; i++)
            {
                PrintLine($"{i + 1}. {items[i]}");
            }
        }

        static void DisplayMenu()
        {
            PrintLine("COMMAND MENU");
            PrintLine("=======================");
            PrintLine("show - show all items");
            PrintLine("grab - grab/add an item");
            PrintLine("edit - edit an item");
            PrintLine("drop - drop an item");
            PrintLine("exit - exit the app");

        }
        static int PromptInt(string prompt, int min, int max)
        {
            int result = 0;
            bool isValid = false;
            while (!isValid)
            {
                Print(prompt);
                string input = Console.ReadLine();
                if (int.TryParse(input, out result))
                {
                    if (result >= min && result <= max) { isValid = true; }
                    else { PrintLine($"\nInvalid input. Please enter a whole number between {min} and {max}."); continue; }
                }
                else if (result < min || result > max)
                {
                    PrintLine($"\nInvalid input. Please enter a whole number between {min} and {max}.");
                    continue;
                }
            }
            return result; ;
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
    }
}
