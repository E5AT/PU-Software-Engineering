namespace ConsoleApp5.Online_Learning_Platform;

public abstract class Course
{
    public string Title { get; set; }
    public double Price { get; set; }
    public int DurationHours { get; set; }

    public Course(string title, double price, int durationHours)
    {
        Title = title;
        Price = price;
        DurationHours = durationHours;
    }
}