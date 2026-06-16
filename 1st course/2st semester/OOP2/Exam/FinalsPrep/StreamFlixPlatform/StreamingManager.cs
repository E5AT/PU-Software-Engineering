namespace StreamFlixPlatform;

public class StreamingManager
{
    public List<Movie> Movies {get;set;}

    public StreamingManager()
    {
        Movies = new();
    }

    public List<string> GetTopSciFiMovies()
    {
        return (from movie in Movies
                where movie.Genre.Equals("Sci-Fi")
                where movie.Rating > 8.0
                select movie.Title).ToList();
    }

    public Dictionary<string, int> GetMovieCountByGenre()
    {
        return Movies.GroupBy(m => m.Genre)
                     .ToDictionary(g => g.Key, g => g.Count());
    }
}
