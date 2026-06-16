namespace MotorsportChampionship;

public enum DrivetrainType
{
    FourWD,
    RWD,
    FWD
}

public class RallyCar : RaceCar, ITuneable
{
    public DrivetrainType DrivetrainType { get; set; }

    public RallyCar(string model, double weight, DrivetrainType drivetrainType)
        : base(model, weight)
    {
        DrivetrainType = drivetrainType;
    }


    public void TuneEngine()
    {
        Console.WriteLine($"Rally car {Model} engine has been tuned!");
    }
}
