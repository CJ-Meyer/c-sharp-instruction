namespace BMDBFileIO
{
    internal class MovieDB
    {
        private const string Dir = @"C:\MAX\C#\ExStarts\Files\";
        private const string Path = Dir + "movies.txt";
        private const string Sep = "|";
        

        public static void SaveMovies(List<Movie> movies)
        {
            using StreamWriter writer = new StreamWriter(new FileStream(Path, FileMode.Create, FileAccess.Write));

            foreach (Movie m in movies)
            {
                writer.Write(m.ID + Sep);
                writer.Write(m.Title + Sep);
                writer.Write(m.Year + Sep);
                writer.Write(m.Rating + Sep);
                writer.WriteLine(m.Director);
            }
        }

        public static List<Movie> GetMovies()
        {
            using StreamReader reader = new(new FileStream(Path, FileMode.Open, FileAccess.Read));
            List<Movie> movies = new List<Movie>();
            while (reader.Peek() != -1)
            {
                string row = reader.ReadLine();
                string[] col = row.Split(Sep);

                if (col.Length == 5)
                {
                    int id = int.Parse(col[0]);
                    string title = col[1];
                    int year = int.Parse(col[2]);
                    string rating = col[3];
                    string director = col[4];
                    Movie m = new Movie(id, title, year, rating, director);
                    movies.Add(m);
                }
            }
            return movies;
        }
    }
}
