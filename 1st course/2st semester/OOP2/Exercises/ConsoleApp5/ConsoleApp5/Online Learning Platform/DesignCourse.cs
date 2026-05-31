namespace ConsoleApp5.Online_Learning_Platform;

public class DesignCourse : Course
{
    public string SoftwareTool{get;set;}

    public DesignCourse(string title, double price, int durationHours, string softwareTool)
        : base(title, price, durationHours)
    {
        SoftwareTool = softwareTool;
    }
}