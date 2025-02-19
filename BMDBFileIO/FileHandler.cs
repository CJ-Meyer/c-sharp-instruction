namespace BMDBFileIO
{
    internal class FileHandler
    {
        private const string FilePath = "movies.txt";

        public static List<Movie> LoadMovies() { 
        List<Movie> movies = new List<Movie>();
        if (File.Exists(FilePath)) {
                foreach (var line in File.ReadAllLines(FilePath)) {
                    var properties = line.Split(',');
        }
    }
}
