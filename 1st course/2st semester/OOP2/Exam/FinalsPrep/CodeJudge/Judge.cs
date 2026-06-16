namespace CodeJudge;

public class Judge : IEvaluator
{
    public void Evaluate(Submission submission)
    {
        if(submission.Code.Contains("print"))
            submission.Status = "Accepted";
        else if(submission.Code.Contains("error"))
            submission.Status = "Runtime Error";
        else
            submission.Status = "Wrong Answer";
    }
}
