using System.Security.Cryptography.X509Certificates;

namespace Chap12Demos
{
    internal class Program
    {
        static List<Movie> Movies = new List<Movie>();
        static void Main(string[] args)
        {
            // try some reading tn
            Console.WriteLine("Welcome to Classes Demos!");
            string choice = "y";
            while (choice == "y")
            {
                //capture input for properties of a movie
                int id = MyConsole.PromptInt("Enter the ID of the movie: ");
                string title = MyConsole.PromptString("Enter the title of the movie: ");
                string director = MyConsole.PromptString("Enter the director of the movie: ");
                int year = MyConsole.PromptInt("Enter the year of the movie: ");
                string ageRating = MyConsole.PromptString("Enter the age rating of the movie: ");

                Movie newMovie = new Movie(id, title, year, ageRating, director);
                Movies.Add(newMovie);
                choice = MyConsole.PromptString("Do you want to enter another movie? (y/n): ");

            }
            //PrintLine(newMovie.ToString());

            MyConsole.PrintLine("============ Movies ============");
            foreach (Movie movie in Movies)
            {
                MyConsole.PrintLine(movie.ToString());
            }


            Console.WriteLine("BYE!");
        }
    }
}
