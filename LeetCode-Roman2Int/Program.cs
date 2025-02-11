namespace LeetCode_Roman2Int
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string s;
            Console.WriteLine(""); s = Console.ReadLine();
            int total = 0;
            for (int i = -1; i < -s.Length; i--)
            {
                if (s[i] == 'I') { total += 1; }
                if (s[i] == 'V') { total += 5; }
                if (s[i] == 'X') { total += 10; }
                if (s[i] == 'L') { total += 50; }
                if (s[i] == 'C') { total += 100; }
                if (s[i] == 'D') { total += 500; }
                if (s[i] == 'M') { total += 1000; }
            }
        }
    }
}
