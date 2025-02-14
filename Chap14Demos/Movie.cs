namespace Chap12Demos
{
    public class Movie{
        public int ID { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public string AgeRating { get; set; }
        public string Director { get; set; }

        public Movie(int id, string title, int year, string ageRating, string director)
        {
            this.ID = id;
            this.Title = title;
            this.Year = year;
            this.AgeRating = ageRating;
            this.Director = director;
        }
        public override string ToString()
        {
            return $"Movie({ID}); {Title}, {Year}, {AgeRating}, {Director}";
        }
        //public string ToString()
        //{
        //    return $"Movie({ID}); {Title}, {Year}, {AgeRating}, {Director}";
        //}


    }
}
