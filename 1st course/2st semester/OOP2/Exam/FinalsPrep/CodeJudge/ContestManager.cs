namespace CodeJudge;

public class ContestManager
{
    List<Submission> Submissions;

    public ContestManager()
    {
        Submissions = new();
    }

    public List<string> GetSuccessfulUsernames()
    {
        return (from submission in Submissions
               where submission.Status.Equals("Accepted")
               select submission.Author.Username).Distinct().ToList();
    }

    public Dictionary<string, int> GetSubmissionCountByStatus()
    {
        return Submissions.GroupBy(s => s.Status)
                          .ToDictionary(s => s.Key, s => s.Count());
    }

    public List<Submission> GetCheatersReport(string forbiddenWord)
    {
        return Submissions.Where(s => s.Code.Contains(forbiddenWord))
                          .OrderBy(s => s.Author.Username)
                          .ToList();
    }

}
