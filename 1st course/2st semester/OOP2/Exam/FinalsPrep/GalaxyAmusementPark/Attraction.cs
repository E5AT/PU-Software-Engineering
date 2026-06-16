namespace GalaxyAmusementPark;

public abstract class Attraction
{
    public string Name { get; set; }
    public int BaseCapacity
    {
        get;
        init
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public Attraction(string name, int baseCapacity)
    {
        Name = name;
        BaseCapacity = baseCapacity;
    }
}

public interface IMaintainable
{
    public void PerformInspection(out string report);
}

public class RollerCoaster : Attraction, IMaintainable
{
    public double MaxSpeed
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public void PerformInspection(out string report)
    {
        report = $"RollerCoaster {Name} inspected. Track speed is {MaxSpeed} km/h.";
    }

    public RollerCoaster(string name, int baseCapacity, double maxSpeed)
        : base(name, baseCapacity)
    {
        MaxSpeed = maxSpeed;
    }
}

public class VirtualRealitySimulator : Attraction, IMaintainable
{
    public int VrHeadsetCount
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public void PerformInspection(out string report)
    {
        report = $"VR Simulator {Name} inspected. {VrHeadsetCount} headsets are clean and ready.";
    }

    public VirtualRealitySimulator(string name, int baseCapacity, int vrHeadsetsCount)
        : base(name, baseCapacity)
    {
        VrHeadsetCount = vrHeadsetsCount;
    }
}

public record Visitor(string TicketId, int Age, bool IsVIP);

public class VIPLounge<T> where T : Visitor
{
    public int MaxCapacity
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public List<T> CurrentGuests;

    public VIPLounge(int maxCapacity)
    {
        MaxCapacity = maxCapacity;
        CurrentGuests = new();
    }

    public bool AdmitGuest(T guest)
    {
        if(CurrentGuests.Count == MaxCapacity)
        {
            Console.WriteLine("Lounge is full");
            return false;
        }

        if(guest.IsVIP == false)
        {
            Console.WriteLine("Standart visitors are not allowed in VIP Lounge");
            return false;
        }

        CurrentGuests.Add(guest);
        return true;
    }
}
