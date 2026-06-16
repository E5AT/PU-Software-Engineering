namespace CyberneticAugmentationMatrix;

public enum Type
{
    Neural,
    Ocular,
    Combat
}

public class Augmentation
{
    public string Name { get; set; }

    public Type Type { get; set; }

    public double PowerConsumption
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

    public Augmentation(string name, Type type, double powerConsumption)
    {
        Name = name;
        Type = type;
        PowerConsumption = powerConsumption;
    }
}

public interface ISecureSystem
{
    public bool ExecuteDiagnostic(out string log);
}

public class AndroidOS
{
    public string Model { get; set; }

    public double MaxEnergyCapacity
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

    public List<Augmentation> InstalledAugmentations;

    private double TotalPowerConsumption
    {
        get
        {
            return InstalledAugmentations.Sum(a => a.PowerConsumption);
        }
    }

    public AndroidOS(string model, double maxEnergyCapacity)
    {
        Model = model;
        MaxEnergyCapacity = maxEnergyCapacity;
        InstalledAugmentations = new();
    }

    Action<string> OnSuccessAugInstall = name =>
        Console.WriteLine($"Инсталацията на {name} е успешна!");

    Action<string> OnUnsuccesAugInstall = name =>
        Console.WriteLine($"Критично претоварване! Инсталацията на {name} е отказана.");

    public void InstallAugmentation(in Augmentation aug)
    {
        if(aug is null)
            return;
        if(TotalPowerConsumption + aug.PowerConsumption > MaxEnergyCapacity)
            OnUnsuccesAugInstall(aug.Name);
        else
        {
            InstalledAugmentations.Add(aug);
            OnSuccessAugInstall(aug.Name);
        }
    }
}

public class CyberMatrix : ISecureSystem
{
    public string MatrixId { get; set; }

    public List<AndroidOS> Androids;

    public CyberMatrix(string matrixId)
    {
        MatrixId = matrixId;
        Androids = new();
    }


    public bool ExecuteDiagnostic(out string log)
    {
        if(Androids.Count != 0)
        {
            log = $"Всички системи работят нормално. {Androids.Count} андроида онлайн.";
            return true;
        }

        log = "Матрицата е празна";
        return false;
    }

    public IEnumerable<object> GetPowerReport()
    {
        return
            Androids
                .SelectMany(android => android.InstalledAugmentations)
                .Select(aug => new
                        {
                            ImplantName = aug.Name,
                            IsHighVoltage = aug.PowerConsumption > 50
                        });
    }


}
