using System;

namespace TechEdu;

public class Video : EducationFormat
{
    public int Duration // in hours
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Duration cannot be negative!");
        }
    }

    public override decimal CalculatePrice
    {
        get
        {
            return FixedRate * Duration;
        }
    }

    public Video(string code, decimal fixedRate, int duration)
        : base(code, fixedRate)
    {
        Duration = duration;
    }
}
