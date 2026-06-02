using System;

namespace TechSpace;

public class Office : Workspace
{
    public decimal CalculateExtraFee()
    {
        return 2m; // 2€ for access card
    }

    public override decimal CalculatePrice(int duration)
    {
        if(duration is < 0)
            throw new ArgumentOutOfRangeException(nameof(duration), "Days cannot be negative!");
        return (duration*BaseRent) + CalculateExtraFee();
    }

    public Office(string signature, decimal baseRent)
        : base(signature, baseRent)
    {
    }

}
