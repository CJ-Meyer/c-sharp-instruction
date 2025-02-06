using System.Globalization;

namespace Chap08Lists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to collections!");

            //just for reference
            Random rand = new Random();
            int dieRoll = rand.Next(1, 7);

            // p.257
            List<int> number = new List<int>();
            number.Add(1);
            number.Add(2);
            number.Add(3);
            number.Add(4);
            foreach (int i in number)
            {
                Console.WriteLine(i + " ");
            }
            Console.WriteLine();

            List<string> names = new List<string>();
            names.Add("Jim");
            names.Add("Andy");
            names.Add("Nick");
            names.Add("Christian");
            names.Add("Adrian");
            names.Add("Sean");
            names.Add("Celina");
            names.Add("Heath");
            names.Add("Joe");

            names.Insert(3,"test");

            foreach (string n in names)
            {
                Console.Write(n+" ");
            }
            Console.WriteLine("\n");

            Console.WriteLine(names.Contains("Adrian"));

            names.Remove("test");
            foreach (string n in names)
            {
                Console.Write(n + " ");
            }
            Console.WriteLine("\n");

            // whats the index position for "Celina"?
            Console.WriteLine("Celina in postion: " + names.BinarySearch("Celina"));
            Console.WriteLine("Celina in postion: " + names.IndexOf("Celina"));

            Console.WriteLine("BYE!");
        }
    }
}
