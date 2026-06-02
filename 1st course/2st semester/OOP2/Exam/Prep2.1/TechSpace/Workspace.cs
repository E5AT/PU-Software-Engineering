namespace TechSpace;

public enum Status
{
    Free,
    Occupied,
    Renovation
}

public abstract class Workspace
{
    public string Signature
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Signature cannot be null!");
            else
                field = value;
        }
    }

    public Status Status{get; set;}
    public abstract decimal CalculatePrice(int duration);
    public decimal BaseRent
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException("Value must be positive!");
        }
    }

    public Workspace(string signature, decimal baseRent)
    {
        Signature = signature;
        Status = Status.Free;
        BaseRent = baseRent;
    }

    public override bool Equals(object? obj)
    {
        if(obj is Workspace otherWorkspace)
            return this.Signature == otherWorkspace.Signature;
        return false;
    }

    public override int GetHashCode()
    {
        return Signature.GetHashCode();
    }


}
