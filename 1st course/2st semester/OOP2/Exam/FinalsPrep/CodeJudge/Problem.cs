namespace CodeJudge;

public class Problem
{
    public string Title {get;set;}
    public string Description {get;set;}

    public Problem(string title, string description)
    {
        Title = title;
        Description = description;
    }

    public override string ToString()
    {
        return $"{Title}: {Description}";
    }
}
