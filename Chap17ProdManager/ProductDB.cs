using ConsoleLibrary;

namespace Chap17ProdManager
{
    internal class ProductDB
    {
        private const string Dir = @"D:\C#\Files";
        private const string Path = Dir + @"\products.txt";
        private const string Sep = "|";
        public static void SaveProducts(List<Product> products)
        {
            using StreamWriter sw = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));
            if (!Directory.Exists(Dir))
            {
                Directory.CreateDirectory(Dir);
                MyConsole.PrintLine("Directory created.");
            }
            foreach (Product p in products)
            {
                sw.Write(p.Code + Sep);
                sw.Write(p.Description + Sep);
                sw.Write(p.Price);
            }
            //sw.Close(); No longer needed thanks to using statement
        }

        public static List<Product> GetProducts()
        {
            using StreamReader sr = new StreamReader(new FileStream(Path, FileMode.OpenOrCreate, FileAccess.Read));
            List<Product> products = new List<Product>();
            while (sr.Peek() != -1)
            {
                string row = sr.ReadLine();
                string[] column = row.Split(Sep);
                if (column.Length == 3)
                {
                    string code = column[0];
                    string description = column[1];
                    decimal price = decimal.Parse(column[2]);
                    Product p = new Product(code, description, price);
                    products.Add(p);
                }

            }
            return products;
        }



    }
}
