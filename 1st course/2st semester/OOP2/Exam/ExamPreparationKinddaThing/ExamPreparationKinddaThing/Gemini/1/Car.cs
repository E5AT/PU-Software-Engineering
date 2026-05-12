using System;

namespace ExamPreparationKinddaThing.Gemini._1;

class Car : Vehicle
{
    private int countPassengers;

    public int CountPassengers
    {
        get => countPassengers;
        set =>
            countPassengers =
                value is >= 0
                    ? value
                    : throw new ArgumentException();
    }

    public Car(string brand, string regNum, double basePrice, int countPassengers)
        : base(brand, regNum, basePrice)
            => CountPassengers = countPassengers;

    public override double CalculateRentalPrice(int days) =>
        (BasePrice * days) * (CountPassengers is > 4 ? 1.1 : 1);

    public override string GetInfo() =>
        $"{base.GetInfo()}, {CountPassengers}";
}