namespace OceanInstitute;

public abstract class MarineEquipment
{
    public string Name { get; set; }
    public double Weight
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

    public MarineEquipment(string name, double weight)
    {
        Name = name;
        Weight = weight;
    }
}

public class SensorBuoy : MarineEquipment, IDataTransmitter
{
    public float MaxDepth
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

    public SensorBuoy(string name, double weight, float maxDepth)
        : base(name, weight)
    {
        MaxDepth = maxDepth;
    }

    public void TransmitData()
    {
        Console.WriteLine($"Sensor Buoy {Name} is transmitting sonar data...");
    }
}

public class Submarine : MarineEquipment, IDataTransmitter
{
    public int MaxEquipment
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

    public Submarine(string name, double weight,int maxEquipment)
        : base(name, weight)
    {
        MaxEquipment = maxEquipment;
    }


    public void TransmitData()
    {
        Console.WriteLine($"Submarine {Name} is transmitting sonar data...");
    }
}

public abstract class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}

public class Diver : Person
{
    public int Age { get; set; }

    public Diver(string name, int age)
        : base(name)
    {
        Age = age;
    }
}

public class MarineBiologist : Person
{
    public string Specialty { get; set; }

    public MarineBiologist(string name, string specialty)
        : base(name)
    {
        Specialty = specialty;
    }
}

public class ResearchVessel
{
    public string Name { get; set; }
    public int DiverCapacity
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

    public ResearchVessel(string name, int diverCapacity)
    {
        Name = name;
        DiverCapacity = diverCapacity;
    }
}


public class OceanExpedition
{
    public string Name { get; set; }
    public ResearchVessel Vessel;
    public List<MarineEquipment> Equipments;
    public List<Diver> Divers;

    public OceanExpedition(string ExpeditionName, string researchVesselName, int diverCapacity)
    {
        Name = ExpeditionName;
        Vessel = new(researchVesselName, diverCapacity);
    }

    public void AddDiver(string name, int age)
    {
        if(Divers.Count < Vessel.DiverCapacity)
            Divers.Add(new Diver(name, age));
        Console.WriteLine("The vessel is already full!");
    }
}

public class OceanInstitute
{
    public string Name { get; set; }
    public List<OceanExpedition> Expeditions;
    public List<MarineBiologist> Biologists;

    public OceanInstitute(string name)
    {
        Name = name;
        Expeditions = new();
        Biologists = new();
    }

    public List<MarineEquipment> GetHeavyEquipment(double minWeight)
    {
        return (from ex in Expeditions
               from eq in ex.Equipments
               where eq.Weight > minWeight
               select eq).ToList();
    }

    public List<Submarine> GetDeployedSubmarines()
    {
        return Expeditions.SelectMany(e => e.Equipments)
                          .OfType<Submarine>()
                          .ToList();
    }

    public double GetAverageDiverAge()
    {
        return Expeditions.SelectMany(e => e.Divers).Average(d => d.Age);
    }
}

public interface IDataTransmitter
{
    public void TransmitData();
}
