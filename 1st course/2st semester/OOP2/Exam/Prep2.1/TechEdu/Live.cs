using System;
using System.Runtime.ExceptionServices;

namespace TechEdu;

public class Live : EducationFormat
{
    public int MaxCapacity
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Capacity must be positive!");
            
        }
    }

    public int CurrentCount
    {
        get;
        private set;
    }

    public void IncreaseCurrentCount()
    {
        if(!HasFreeSpaces)
            throw new InvalidOperationException("Cannot add more students, current count is already equal to maximum capacity!");
        CurrentCount++;
    }

    public void DecreaseCount()
    {
        if(CurrentCount==0)
            throw new InvalidOperationException("Cannot decrease the count more, it's already equal to 0!");
        CurrentCount--;
    }

    public decimal MentorFee{
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Mentor fee mmust be positive!");
        }
    }

    public override decimal CalculatePrice
    {
        get
        {
            return FixedRate + MentorFee;
        }
    }

    public Live(string code, decimal fixedRate, int maxCapacity, decimal mentorFee)
        : base(code, fixedRate)
    {
        MaxCapacity = maxCapacity;
        MentorFee = mentorFee;
        CurrentCount = 0;
    }

    public bool HasFreeSpaces
    {
        get => CurrentCount < MaxCapacity;
    }
}
