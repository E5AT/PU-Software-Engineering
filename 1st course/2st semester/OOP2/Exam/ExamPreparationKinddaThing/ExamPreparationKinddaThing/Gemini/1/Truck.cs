using System;

namespace ExamPreparationKinddaThing.Gemini._1;

class Truck : Vehicle
{
    private double capacity;

    public double Capacity
    {
        get => capacity;
        set =>
            capacity =
                value > 0
                    ? value
                    : throw new ArgumentException();
    }
    
    public Truck(string brand, string regNum, double basePrice, int capacity)
        : base(brand, regNum, basePrice)
            => Capacity = capacity;

    public override double CalculateRentalPrice(int days) =>
        (BasePrice + (Capacity * 5)) * days;

    public override string GetInfo() =>
        $"{base.GetInfo()}, {Capacity}";
}