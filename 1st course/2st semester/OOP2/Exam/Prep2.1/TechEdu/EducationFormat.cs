using System.Dynamic;

namespace TechEdu;

public abstract class EducationFormat
{
    public string Code
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Code cannot be null!");
            field = value;
        }
    }

    public decimal FixedRate
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value), "Fixed rate must be positive!");
        }
    }

    public abstract decimal CalculatePrice{get;}

    public EducationFormat(string code, decimal fixedRate)
    {
        Code = code;
        FixedRate = fixedRate;
    }

    public override bool Equals(object? obj)
    {
        if(obj is EducationFormat otherFormat)
            return this.Code == otherFormat.Code;
        return false;
    }

    public override int GetHashCode()
    {
        return Code.GetHashCode();
    }
}
