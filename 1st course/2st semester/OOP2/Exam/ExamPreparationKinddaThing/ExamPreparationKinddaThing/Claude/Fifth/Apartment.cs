using System;

namespace ExamPreparationKinddaThing.Fifth;

class Apartment : Room
{
    int countRooms;
    public int CountRooms
    {
        get =>  countRooms;
        set =>
            countRooms =
                value is > 1
                    ? value
                    : throw new ArgumentException();
    }

    bool containsBreakfast;
    public bool ContainsBreakfast
    {
        get => containsBreakfast;
        set =>
            containsBreakfast = value;
    }
    
    public Apartment(int number, int capacity, double pricePerNight, int countRooms, bool containsBreakfast)
        : base(number, capacity, pricePerNight) =>
            (CountRooms, ContainsBreakfast) = (countRooms, containsBreakfast);

    public override string getInfo() =>
        $"{base.getInfo()}, Count of rooms: {CountRooms}, Contains Breakfast: {ContainsBreakfast}";

    public override string getType() =>
        "Apartment";
}