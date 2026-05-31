namespace ConsoleApp5.Online_Learning_Platform;

public class Lesson
{
    public string Title { get; set; }
    public int DurationMinutes { get; set; }

    public Lesson(string title, int durationMinutes)
    {
        Title = title;
        DurationMinutes = durationMinutes;
    }
}