using System.Diagnostics.Metrics;

namespace Project_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Batting statistics
            //Print("Welcome to the Batting Average Calculator\n");

            // while choice == "y"
            //prompt user => nbrAtBat: Int
            //create array => atBat: int[nbrAtBat]
            //for i = 0; i<= nbrAtBat; i++
            //prompt user => result: int


            //string choice = "y";
            //while (choice == "y")
            //{
            //    int bats = 0;
            //    double current = 0;
            //    double total = 0;
            //    double Counter = 0;
            //    Print("Enter number of times at bat: "); bats = Int32.Parse(Console.ReadLine());
            //    PrintLine("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");
            //    for (int i = 1; i <= bats; i++)
            //    {
            //        Print("\nResult for at-bat" + i + ":"); current = Double.Parse(Console.ReadLine());
            //        total += current;
            //        if (current > 0) { Counter++; }

            //    }
            //    PrintLine("Batting average: " + Counter / bats);
            //    PrintLine("\nSlugging perent: " + total / bats);
            //    Print("\nAnother player (y/n): \n"); choice = Console.ReadLine().ToLower();
            //}

            // Batting statistics with arrays

            PrintLine("Welcome to the Batting Average Calculator\n");
            string choice = "y";

            while (choice == "y")
            {
                int bats = GetValidInt("Enter number of times at bat: ", 1, 30);
                int[] results = GetBatResults(bats);
                double battingAverage, sluggingPercentage;
                CalculateStats(results, out battingAverage, out sluggingPercentage);

                PrintLine($"\nBatting Average: {battingAverage:F3}");
                PrintLine($"Slugging Percentage: {sluggingPercentage:F3}");

                choice = GetValidChoice("\nAnother player (y/n): ");
            }
            // 8-2 sales report
            // for project 8-2 Sales Report
            // regions for rows 1,2,3,4 and Q1,Q2,Q3,Q4 for columns
            // sales by region, region[i++]
            // sales by quarters, quarter[++]
            //total sales 
            PrintLine("The Sales Report application\n");
            double[,] sales = { {1540.0, 2010.0, 2450.0, 1845.0},
                                {1130.0, 1168.0, 1847.0, 1491.0},
                                {1580.0, 2305.0, 2710.0, 1284.0},
                                {1105.0, 4102.0, 2391.0, 1576.0}};
            PrintLine("Region\tQ1\t\tQ2\t\tQ3\t\tQ4\t");
            Sales1(sales);
            regional(sales);
            quarter(sales);
            PrintLine(Sales2(sales));

            PrintLine("GoodBYE!");
        }

        private static void regional(double[,] sales)
        {
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                double total = 0;
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    total += sales[i, j];
                }
                PrintLine("Region " + (i + 1) + ": " + total.ToString("c"));
            }
            PrintLine("");
        }

        private static void quarter(double[,] sales)
        {
            for (int i = 0; i < sales.GetLength(1); i++)
            {
                double total = 0;
                for (int j = 0; j < sales.GetLength(0); j++)
                {
                    total += sales[j, i];
                }
                PrintLine("Quarter " + (i + 1) + ": " + total.ToString("c"));
            }
            PrintLine("");
        }

        // sales report pt1 method
        private static void Sales1(double[,] sales)
        {
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                string saleArray = "";
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    saleArray += (sales[i, j].ToString("c") + "\t");
                }
                PrintLine((i + 1) + "\t" + saleArray);
            }
            PrintLine("");
        }

        static string Sales2(double[,] sales)
        {
            double saleArray = 0.0;
            for (int i = 0; i < sales.GetLength(0); i++)
            {
                for (int j = 0; j < sales.GetLength(1); j++)
                {
                    saleArray += (sales[i, j]);
                }
            }
            string result = ("\nTotal sales: " + saleArray.ToString("c") + "\n");
            return result;
        }

        // print method 
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
        static int[] GetBatResults(int bats)
        {
            int[] results = new int[bats];

            PrintLine("\n0 = out, 1 = single, 2 = double, 3 = triple, 4 = home run");

            for (int i = 0; i < bats; i++)
            {
                results[i] = GetValidInt("Enter valid integer for result at bat: ", 0, 4);
            }
            return results;
        }
        static void CalculateStats(int[] results, out double battingAverage, out double sluggingPercentage)
        {
            double hits = 0, totalBases = 0;

            foreach (int result in results)
            {
                if (result > 0) hits++;
                totalBases += result;
            }

            battingAverage = hits / results.Length;
            sluggingPercentage = totalBases / results.Length;
        }
    }
}
