namespace CodeJudge;

public class Submission
{
    public User Author {get;set;}
    public string Code {get;set;}
    public string Status {get;set;}

    public Submission(User author, string code)
    {
        Author = author;
        Code = code;
        Status = "Pending";
    }

    public override string ToString()
    {
        return $"Submission by {Author.Username}";
    }
}
