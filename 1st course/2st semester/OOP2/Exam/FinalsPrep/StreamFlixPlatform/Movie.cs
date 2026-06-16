namespace StreamFlixPlatform;

public class Movie
{
    public string Title {get;set;}
    public string Genre {get;set;}
    public double Rating {get;set;}

    public Movie(string title, string genre, double rating)
    {
        Title = title;
        Genre = genre;
        Rating = rating;
    }
}
