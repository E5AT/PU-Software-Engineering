using System;

namespace ExamPreparationKinddaThing.Fifth;

class Standard : Room
{
    string typeBed;
    public string TypeBed
    {
        get => typeBed;
        set =>
            typeBed =
                !string.IsNullOrWhiteSpace(value)
                    ? value
                    : throw new ArgumentNullException();
    }
    
    public Standard(int number, int capacity, double pricePerNight, string typeBed)
        : base(number, capacity, pricePerNight) =>
            TypeBed = typeBed;

    public override string getInfo() =>
        $"{base.getInfo()}, Type of Bed: {TypeBed}";

    public override string getType() =>
        "Standard";
}