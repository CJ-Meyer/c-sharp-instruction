using ConsoleLibrary;

namespace Chap17ProdManager {
    internal class Program {
        static List<Product> products = new List<Product>();
        static void Main(string[] args) {
            MyConsole.PrintLine("Welcome to the product manager!");

            // program that provides CRUD features for products
            // Products will be stored in a txt  file named products.txt

            // Load products from file

            products = ProductDB.GetProducts();

            int command = 9;
            while (command != 0)
            {
                DisplayMenu();
                command = MyConsole.PromptInt("Command: ");
                switch (command)
                {
                    case 1:
                        ListProducts();
                        break;
                    case 2:
                        AddProduct();
                        break;
                    case 3:
                        UpdateProduct();
                        break;
                    case 4:
                        DeleteProduct();
                        break;
                    case 0:
                        break;
                    default:
                        MyConsole.PrintLine("Invalid Command. Try again.");
                        break;
                }
            }
            //while command !=0

            MyConsole.PrintLine("BYE!");
        }
        private static void DeleteProduct() {
            MyConsole.PrintLine("\nDelete a product");
            MyConsole.PrintLine("========================================");
            string code = MyConsole.PromptString("Enter product code to be deleted: ");
            bool found = false;
            for (int i = 0; i < products.Count; i++)
            {
                if (products[i].Code == code)
                {
                    products.RemoveAt(i);
                    found = true; // if found, set to true, go to if statement below
                    break; // Exit after deleting the product
                }
            }
            if (!found) {
                MyConsole.PrintLine("Code entered is not found in our database.");
            } else {
                ProductDB.SaveProducts(products);
                MyConsole.PrintLine("Product deleted.");
            }
        }
        private static void UpdateProduct() {
            MyConsole.PrintLine("\nUpdate a product");
            MyConsole.PrintLine("========================================");
            string code = MyConsole.PromptString("Enter product code to be updated: ").Trim();

            bool found = false;

            foreach (Product p in products)
            {
                if (p.Code == code) 
                {
                    string description = MyConsole.PromptString("Enter NEW product description: ").Trim();
                    decimal price = MyConsole.PromptDecimal("Enter NEW product price: ");

                    p.Description = description;
                    p.Price = price;

                    found = true;
                    break; // Stop loop once updated
                }
            }

            if (found)
            {
                ProductDB.SaveProducts(products);
                MyConsole.PrintLine("Product updated.");
            }
            else
            {
                MyConsole.PrintLine("Code entered is not found in our database.");
            }
        }
        private static void AddProduct() {
            MyConsole.PrintLine("\nAdd a product");
            MyConsole.PrintLine("========================================");
            string code = MyConsole.PromptString("Enter product code: ");
            string description = MyConsole.PromptString("Enter product description: ");
            decimal price = MyConsole.PromptDecimal("Enter product price: ");
            Product p = new Product(code, description, price);
            products.Add(p);
            ProductDB.SaveProducts(products);
            MyConsole.PrintLine("Product added.");
        }
        private static void ListProducts() {
            MyConsole.PrintLine("\nList of products");
            MyConsole.PrintLine("========================================");
            foreach (Product p in products)
            {
                MyConsole.PrintLine(p.ToString());
            }
        }

        static void DisplayMenu()
        {
            MyConsole.PrintLine("\nCommand Menu:");
            MyConsole.PrintLine("1) List all products");
            MyConsole.PrintLine("2) Add a product");
            MyConsole.PrintLine("3) Update a product");
            MyConsole.PrintLine("4) Delete a product");
            MyConsole.PrintLine("0) Exit");
        }
    }
}
