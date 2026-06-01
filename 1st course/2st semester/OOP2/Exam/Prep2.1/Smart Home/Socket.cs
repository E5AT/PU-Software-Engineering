namespace Smart_Home;

public class Socket : Device
{
    public double PowerAttached
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException("Power of the attached device must be positive!");
        }
    }

    public override double ConsumedElectricity
    {
        get
        {
            return Status == Status.On ? PowerAttached : 0;
        }
    }

    public Socket(string serialNumber, Status status, double powerAttached)
        : base(serialNumber, status)
    {
        PowerAttached = powerAttached;
    }
}