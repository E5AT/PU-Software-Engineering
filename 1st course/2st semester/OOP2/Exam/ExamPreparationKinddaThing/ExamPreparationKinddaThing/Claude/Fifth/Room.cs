using System;

namespace ExamPreparationKinddaThing.Fifth
{
    abstract class Room
    {
        int number;
        public int Number
        {
            get => number;
            set =>
                number =
                    value is > 0
                        ? value
                        : throw new ArgumentException();
        }

        int capacity;
        public int Capacity
        {
            get => capacity;
            set =>
                capacity =
                    value is >= 1 and <= 6
                        ? value
                        : throw new ArgumentException();
        }
        
        double pricePerNight;
        public double PricePerNight
        {
            get => pricePerNight;
            set =>
                pricePerNight =
                    value is > 0
                        ? value
                        : throw new ArgumentException();
        }

        public Room(int number, int capacity, double pricePerNight) =>
            (Number, Capacity, PricePerNight) = (number, capacity, pricePerNight);
        
        public virtual string getInfo() =>
            $"Num: {Number}, Capacity: {Capacity}, Price per night: {PricePerNight}";

        public abstract string getType();
    }
}