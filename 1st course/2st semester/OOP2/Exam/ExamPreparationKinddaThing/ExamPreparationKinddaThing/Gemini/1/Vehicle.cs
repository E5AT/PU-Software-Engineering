using System;

namespace ExamPreparationKinddaThing.Gemini._1;

abstract class Vehicle
{
    private string brand;

    public string Brand
    {
        get => brand;
        set =>
            brand =
                value.Length is > 3
                    ? value
                    : throw new ArgumentException();
    }

    private string regNum;

    public string RegNum
    {
        get => regNum;
        set =>
            regNum =
                !string.IsNullOrWhiteSpace(value)
                    ? value
                    : throw new ArgumentException();
    }

    private double basePrice;

    public double BasePrice
    {
        get => basePrice;
        set =>
            basePrice =
                value is > 3
                    ? value
                    : throw new ArgumentException();
    }
    
    public Vehicle(string brand, string regNum, double basePrice) =>
        (Brand, RegNum, BasePrice) = (brand, regNum, basePrice);

    public abstract double CalculateRentalPrice(int days);

    public virtual string GetInfo() =>
        $"{Brand}, {RegNum}, {Math.Round(BasePrice, 2)}";
}