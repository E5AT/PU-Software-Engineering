namespace AirportFlightManagement;

public abstract class Aircraft
{
    public string Model { get; set; }

    public double MaxTakeoffWeight
    {
        get;
        set
        {
            if(value > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public Aircraft(string model, double maxTakeoffWeight)
    {
        Model = model;
        MaxTakeoffWeight = maxTakeoffWeight;
    }
}


public class PassengerPlane : Aircraft, IMaintainable
{
    public int PassengerCapacity
    {
        get;
        set
        {
            if(value > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public PassengerPlane(string model, double maxTakeoffWeight, int passengerCapacity)
        : base(model, maxTakeoffWeight)
    {
        PassengerCapacity = passengerCapacity;
    }


    public void PerformSafetyCheck()
    {
        Console.WriteLine($"Passenger plane {Model} safety check completed!");
    }
}



public class CargoPlane : Aircraft, IMaintainable
{
    public double MaxCargoVolume
    {
        get;
        set
        {
            if(value > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public CargoPlane(string model, double maxTakeoffWeight, double maxCargoVolume)
        : base(model, maxTakeoffWeight)
    {
        MaxCargoVolume = maxCargoVolume;
    }

    public void PerformSafetyCheck()
    {
        Console.WriteLine($"Cargo plane {Model} safety check completed!");
    }
}


public interface IMaintainable
{
    public void PerformSafetyCheck();
}
