namespace Smart_Home;

public class Room
{
    public int Number{get; init;}
    public string Name
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Name cannot be null or empty!");
            else
                field = value;
        }
    }
    public List<Device> Devices{get; private set;}

    public Room(int number, string name)
    {
        Number = number;
        Name = name;
        Devices = new();
    }

    public void Add(Device device)
    {
        if(device is null)
            throw new ArgumentNullException("Cannot add device that's null!");
        else
            Devices.Add(device);
    }

    public Device Search(string serialNumber)
    {
        Device? device = Devices.FirstOrDefault(d => d.SerialNumber == serialNumber);

        if(device is null)
            throw new InvalidOperationException($"Cannot find device with the serial number: {serialNumber}!");

        return device;
    }

    public void Remove(string serialNumber)
    {
            Devices.Remove(Search(serialNumber));
    }

    public void UpdateDeviceStatus(Status status, string serialNumber)
    {
        foreach(Device device in Devices)
            if(device.SerialNumber == serialNumber)
                device.Status = status;
    }

    public bool Has(string serialNumber)
    {
        foreach(Device device in Devices)
            if(device.SerialNumber == serialNumber)
                return true;
        return false;
    }
}