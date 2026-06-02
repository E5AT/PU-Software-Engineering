using System;

namespace TechSpace;

public class Desk : Workspace
{

    public override decimal CalculatePrice(int duration)
    {
        if(duration is < 0)
            throw new ArgumentOutOfRangeException(nameof(duration), "Hours cannot be negative!");
        return BaseRent * duration;
    }

    

    public Desk(string signature, decimal baseRent)
        : base(signature, baseRent)
    {
    }
}
