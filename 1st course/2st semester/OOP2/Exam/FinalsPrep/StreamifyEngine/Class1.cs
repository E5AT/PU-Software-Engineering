namespace StreamifyEngine;

public abstract class Content
{
    public string Title { get; set; }
    public string Genre { get; set; }
    public int DurationInSeconds
    {
        get;
        init
        {
            if(value > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public Content(string title, string genre, int duration)
    {
        Title = title;
        Genre = genre;
        DurationInSeconds = duration;
    }
}

public class Movie : Content
{
    public double DirectorScore
    {
        get;
        set
        {
            if(value is >= 1 and <= 10)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public Movie(string title, string genre, int duration, double score)
        : base(title, genre, duration)
    {
        DirectorScore = score;
    }
}

public class Episode : Content
{
    public int SeasonNumber
    {
        get;
        private set;
    }

    public bool UpdateSeasonNumber(int newNum)
    {
        if(newNum >= SeasonNumber)
        {
            SeasonNumber = newNum;
            return true;
        }

        return false;
    }

    public Episode(string title, string genre, int duration, int seasonNumber)
        : base(title, genre, duration)
    {
        SeasonNumber = seasonNumber;
    }
}


public class UserAccount
{
    public string Username
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public bool IsPremium { get; set; }

    public event Action<Content> OnContentWatched;

    public void Watch(Content content)
    {
        OnContentWatched?.Invoke(content);
    }
}

public class StreamingService
{
    public string PlatformName { get; set; }
    public List<Content> Library;
    public List<UserAccount> Users;

    public StreamingService(string name)
    {
        PlatformName = name;
        Library = new();
        Users = new();
    }
    
    public Dictionary<string, List<Content>> GetCatalogBySize()
    {
        return
            Library
                .GroupBy(c => c.Genre)
                .ToDictionary(g => g.Key, g => g.ToList());
    }

    public List<string> GetTopPremiumMovies(double score)
    {
        return (from c in Library
               where c is Movie
               let movie = c as Movie
               where movie != null && movie.DirectorScore > score
               select movie.Title).ToList();
    }

    public double GetTotalWatchTime()
    {
        return Library.Sum(c => c.DurationInSeconds) / (double)(60*60);
    }

}
