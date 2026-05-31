namespace ConsoleApp5.Online_Learning_Platform;

public class Assignment
{
    public string Title { get; set; }
    public int MaxPoints { get; set; }
    
    public Assignment(string title, int maxPoints)
    {
        Title = title;
        MaxPoints = maxPoints;
    }
}