namespace BMDBFileIO
{
    internal class Movie
    {
        // init variables
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string Rating { get; set; }
        public string Director { get; set; }

        // Use all variables in Movie constructor. Set parameters equal to corresponding public variable
        public Movie(int id, string title, int year, string rating, string director)
        {
            ID = id;
            Title = title;
            Year = year;
            Rating = rating;
            Director = director;
        }
        // returns string of display text
    public string ToString()
        {
            return $"ID: {ID}\nTitle: {Title}\nYear: {Year}\nRating: {Rating}\nDirector: {Director}\n";
        }
    }
}
