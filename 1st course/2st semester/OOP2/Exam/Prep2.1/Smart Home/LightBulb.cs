namespace Smart_Home;

public class LightBulb : Device
{
    public double FixedPower
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException("Base power must be positive!");
        }
    }

    public override double ConsumedElectricity
    {
        get
        {
            return Status == Status.On ? FixedPower : 0;
        }
    }

    public LightBulb(string serialNumber, Status status, double fixedPower)
        : base(serialNumber, status)
    {
        FixedPower = fixedPower;
    }
}