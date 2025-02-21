using ConsoleLibrary;

namespace BMDBFileIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to BMDB File IO\n");

            Movie m1 = new Movie(1, "Spaceballs", 1985, "PG", "Mel Brooks");
            Movie m2 = new Movie(2, "totally awesome", 2025, "pg-13", "Sean Blessing");
            List<Movie> movies = new List<Movie>();
            movies.Add(m1);
            movies.Add(m2);

            MovieDB.SaveMovies(movies);
            movies = MovieDB.GetMovies();

            movies.ForEach(m => MyConsole.PrintLine(m.ToString()));


            MyConsole.PrintLine("\nBYE!");
        }
    }
}
