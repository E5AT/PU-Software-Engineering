namespace GreenEnergyGrid;

public abstract class PowerPlant
{
    public string Name {get; set;}
    public double Efficiency
    {
        get;
        set
        {
            if(value is >= 0.0 or <= 1.0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public PowerPlant(string name, double efficiency)
    {
        Name = name;
        Efficiency = efficiency;
    }
}

public class SolarPlant : PowerPlant, IEnergyGenerator
{
    public int PanelCount
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

    public double SunExposureHours
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

    public double CalculateCurrentOutput()
    {
        return PanelCount * SunExposureHours * Efficiency;
    }

    public SolarPlant(string name, double efficiency, int panelCount, double sunExposureHours)
        : base(name, efficiency)
    {
        PanelCount = panelCount;
        SunExposureHours = sunExposureHours;
    }
}

public class WindPlant : PowerPlant, IEnergyGenerator, IStorable
{
    public int TurbineCount
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

    public double BatteryCapacity
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

    public double CurrentStoredEnergy
    {
        get;
        private set
        {
            if(value <= BatteryCapacity)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }


    public WindPlant(string name, double efficiency, int panelCount, int turbineCount, double batteryCapacity, double currentStoredEnergy)
        : base(name, efficiency)
    {
        TurbineCount = turbineCount;
        BatteryCapacity = batteryCapacity;
        CurrentStoredEnergy = currentStoredEnergy;
    }

    public double CalculateCurrentOutput()
    {
        return TurbineCount * 2.5 * Efficiency;
    }

    public bool StoreExcessEnergy(double energyAmount, out string logMessage)
    {
        if((CurrentStoredEnergy + energyAmount) > BatteryCapacity)
        {
            CurrentStoredEnergy = BatteryCapacity;
            logMessage = "Battery overcharged! Stored max capacity.";
            return false;
        }
        else
        {
            CurrentStoredEnergy += energyAmount;
            logMessage = $"Successfully stored {energyAmount} MW.";
            return true;
        }
    }
}
