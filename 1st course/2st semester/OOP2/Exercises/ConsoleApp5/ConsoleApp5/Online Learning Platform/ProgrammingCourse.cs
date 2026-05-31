namespace ConsoleApp5.Online_Learning_Platform;

public class ProgrammingCourse : Course
{
    public string ProgrammingLanguage { get; set; }
    public bool HasFinalProject { get; set; }

    public ProgrammingCourse(string title, double price, int durationHours, string programmingLanguage,
        bool hasFinalProject)
        : base(title, price, durationHours)
    {
        ProgrammingLanguage = programmingLanguage;
        HasFinalProject = hasFinalProject;
    }
}