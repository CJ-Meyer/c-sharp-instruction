﻿using ConsoleLibrary;

namespace Chap17ProdManager {
    internal class Program {
        static List<Product> products = new List<Product>();
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the product manager!");

            // program that provides CRUD features for products
            // Products will be stored in a txt  file named products.txt

            // Load products from file

            //while command !=0

            MyConsole.PrintLine("BYE!");
        }
        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCommand Menu:");
            MyConsole.PrintLine("1) Add a product");
            MyConsole.PrintLine("2) List all products");
            MyConsole.PrintLine("0) Exit");
        }
    }
}
