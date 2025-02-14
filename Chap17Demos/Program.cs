using ConsoleLibrary;

namespace Chap17Demos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyConsole.PrintLine("Welcome to the file demo\n");

            string dir = @"D:\C#\Files\";
            if (!Directory.Exists(dir))
            {
                Directory.CreateDirectory(dir);
                MyConsole.PrintLine("Directory created");
            }
            else
            {
                MyConsole.PrintLine("Directory already exists");
            }
            string path = dir + "names.txt";
            if (File.Exists(path))
            {
                MyConsole.PrintLine("File already exists");
            }
            else
            {
                File.Create(path);
                MyConsole.PrintLine("File created");
            }

            //write some names to our file...
            //StreamWriter writer = new StreamWriter(new FileStream(path, FileMode.Create, FileAccess.Write));
            //writer.WriteLine("Adrian");
            //writer.WriteLine("Celina");
            //writer.WriteLine("Heath");
            //writer.WriteLine("Nick");
            //writer.WriteLine("Joe");
            //writer.WriteLine("Christian");
            //writer.WriteLine("Jim");
            //writer.WriteLine("Drew");
            //writer.Close();
            //MyConsole.PrintLine("Names written to file");
            MyConsole.PrintLine("==== reading names.txt ====");
            StreamReader reader = new StreamReader(
                new FileStream(path, FileMode.Open, FileAccess.Read));
            List<string> lines = new List<string>();
            while (reader.Peek() != -1)
            {
                string row = reader.ReadLine() ?? "";
                lines.Add(row);
            }
            reader.Close();
            foreach (string line in lines)
            {
                MyConsole.PrintLine($"Line: {line}");
            }
            MyConsole.PrintLine("BYE!");
        }
    }
}
