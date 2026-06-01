namespace Smart_Home;

public class SmartHomeSystem
{
    List<Room> Rooms;
    private Dictionary<string, Device> _globalDevices;
    private int index = 1;
    
    public SmartHomeSystem()
    {
        Rooms = new();
        _globalDevices = new();
    }

    public void AddRoom(string name)
    {
        Rooms.Add(new Room(index++, name));
    }

    public void AddDevice(Device device, string nameRoom)
    {
        if(device is null)
            throw new ArgumentNullException("Cannot add device that's null!");
        
        if(_globalDevices.ContainsKey(device.SerialNumber))
            throw new InvalidOperationException("There is already a device with the same serial number!");

        Room room = SearchRoom(nameRoom);
        room.Add(device);

        _globalDevices.Add(device.SerialNumber, device);
    }

    public Room SearchRoom(string name)
    {
        Room? room = Rooms.FirstOrDefault(r => r.Name == name);

        if(room is null)
            throw new InvalidOperationException($"Cannot find room with the name: {name}!");

        return room;
    }

    public void MoveDevice(string serialNumber, string fromName, string toName)
    {
        if(!_globalDevices.TryGetValue(serialNumber, out Device? deviceToMove))
            throw new InvalidOperationException("There is no device like that!");

            Room fromRoom = SearchRoom(fromName);
            Room toRoom = SearchRoom(toName);

            if(!fromRoom.Has(serialNumber))
                throw new InvalidOperationException($"There is no device like that in the room {fromName}");

            fromRoom.Remove(serialNumber);
            toRoom.Add(deviceToMove);
    }

    public void UpdateStatus(Status status, string serialNumber)
    {
        if(_globalDevices.TryGetValue(serialNumber, out Device? device))
            device.Status = status;
        else
            throw new InvalidOperationException("Cannot find device!");
    }

    public double CalculateTotalConsumption()
    {
        double totalConsumption = 0;

        foreach(Room room in Rooms)
            foreach(Device device in room.Devices)
                totalConsumption += device.ConsumedElectricity;

        return totalConsumption;
    }

    public List<Device> Diagnostics()
    {
        return _globalDevices.Values.Where(d => d.Status == Status.Error).ToList();
    }
}