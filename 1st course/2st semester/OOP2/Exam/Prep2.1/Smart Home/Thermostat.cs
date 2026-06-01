namespace Smart_Home;

public class Thermostat : Device
{
    public double CalculateExtraConsumption()
    {
        return 5; // power for the display, even when its off
    }

    public double FullPower
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException("Full power must be positive!");
        }
    }

    public override double ConsumedElectricity
    {
        get
        {
            if(Status == Status.Error)
                return 0;
            return CalculateExtraConsumption() + (Status == Status.On ? FullPower : 0);
        }
    }

    public Thermostat(string serialNumber, Status status, double fullPower)
        : base(serialNumber, status)
    {
        FullPower = fullPower;
    }
}