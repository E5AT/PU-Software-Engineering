using System;

namespace TechSpace;

public class Room : Workspace
{

    public bool Equipments{get; set;}

    public override decimal CalculatePrice(int duration)
    {
        if(duration < 0)
            throw new ArgumentOutOfRangeException(nameof(duration), "Hours cannot be negative!");
        decimal multiplier = Equipments?1.2m:1m; // 20% up if they want equipments
        return (BaseRent*duration)*multiplier;
    }

    public Room(string signature, decimal baseRent, bool equipments)
        : base(signature, baseRent)
    {
        Equipments = equipments;
    }
}
