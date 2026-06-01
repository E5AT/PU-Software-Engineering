namespace Smart_Home;

public enum Status
{
    On,
    Off,
    Error
}

public abstract class Device
{
    public string SerialNumber
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Serial number cannot be null or empty!");
            else if(value.Length != 10)
                throw new ArgumentException("Serial number must be exactly 10 symbols long!");
            else
                field = value;
        }
    }

    public Status Status{get; set;}
    public abstract double ConsumedElectricity{get;}
    // public int OperatingTime
    // {
    //     get;
    //     private set
    //     {
    //         if(value is >= 0)
    //             field = value;
    //         else
    //             throw new ArgumentException("Operating time cannot be negative!");
    //     }
    // }

    // // there is a method for changing the operating time since it has more complex logic
    // public void UpdateOperatingTime(int newOperatingTime)
    // {
    //     if(newOperatingTime > OperatingTime)
    //         OperatingTime = newOperatingTime;
    //     else
    //         throw new ArgumentException("New operating time cannot be lower than current operating time!");
    // }

    public Device(string serialNumber, Status status/*, int operatingTime*/)
    {
        SerialNumber = serialNumber;
        Status = status;
        // OperatingTime = operatingTime;
    }

    public override bool Equals(object? obj)
    {
        if(obj is Device otherDevice)
            return this.SerialNumber == otherDevice.SerialNumber;
        return false;
    }

    public override int GetHashCode()
    {
        return SerialNumber.GetHashCode();
    }

}
