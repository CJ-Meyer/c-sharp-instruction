using ConsoleLibrary;

namespace NumbersApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the numbers app");
            //define two int variables

            int num1 = 11;
            int num2 = 22;

            MyConsole.PrintLine(sum(num1, num2).ToString());
            List<int> numbers = new List<int>() {1, 2, 3, 4};
            string numberList = "";
            for (int i = 0; i < numbers.Count; i++) { 
                numberList += $"{numbers[i]}|";
            }
            MyConsole.PrintLine(numberList);

        }
        private static int sum(int x, int y)
        {
            return x + y;
        }
    }
}
