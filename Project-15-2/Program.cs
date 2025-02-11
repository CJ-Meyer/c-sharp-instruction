using System.ComponentModel.DataAnnotations;

namespace Project_15_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PrintLine("The Wizard Inventory game");
            string[] inventory = new string[4];
            inventory[0] = "wooden staff";
            inventory[1] = "wizard hat";
            inventory[2] = "cloth shoes";
            //Display the command menu

            //Display chosen command
            string command = Console.ReadLine().ToLower(); Print("Command: "+ command);
            //show - Show all items
            // shows the items in the inventory in 1., 2., 3., 4. format


            // grab - Grab an item
            // Display Name: potion of invisibility
            // Display potionMotion has been added.
            // If the inventory is full (>4), display "You can't carry any more items. Drop something first."
            Print("Command: "); string grabName  = Console.ReadLine();
                if 
            Print($"Name: {grabName}");
            Print($"{grabName} was added.");


            // edit - Edit an item
            //For the edit and drop commands, display an error message if the user enters an
            //invalid number for the item
            //Print("Which number item would you like to edit? "); int editNum = Int32.Parse(Console.ReadLine());
            //Print(""); int updName = Int32.Parse(Console.ReadLine());
            //Print($"Item number {editNum}");
            // drop - Drop an item
            //Print("Number: "); int dropNum = Int32.Parse(Console.ReadLine());
            //Print($"Item name {dropNum} has been dropped.");
            //exit - Exit program
            //When you exit the program, all changes that you made to the inventory are lost
            //Print("GoodBYE!");




            PrintLine("GoodBYE!");
        }
        //static string Sales2(double[,] sales)
        //{
        //    // placeholder for initial values
        //    for (int i = 0; i < sales.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < sales.GetLength(1); j++)
        //        {
        //            InitialValue += (sales[i, j]);
        //        }
        //    }
        //    // result = ;
        //    return result;
        //}
        
        // print methods
        static void PrintLine(string msg)
        {
            Console.WriteLine(msg);
        }
        static void Print(string msg)
        {
            Console.Write(msg);
        }
        static int GetValidInt(string message, int min, int max)
        {
            int value;
            while (true)
            {
                Print(message);
                if (int.TryParse(Console.ReadLine(), out value) && value >= min && value <= max)
                {
                    return value;
                }
                else { PrintLine("Invalid input. Please enter a valid number."); continue; }
            }
        }
        static string GetValidChoice(string message)
        {
            string input; while (true)
            {
                Print(message);
                input = Console.ReadLine().Trim().ToLower();

                if (input == "y" || input == "n")
                    return input;
                PrintLine("Invalid input. Please enter 'y' for Yes or 'n' for No");
            }
        }
    }
}
