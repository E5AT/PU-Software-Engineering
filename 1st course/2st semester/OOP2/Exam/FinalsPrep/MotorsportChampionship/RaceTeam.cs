namespace MotorsportChampionship;

public class RaceTeam
{
    public string TeamName { get; set; }
    public List<RaceCar> Cars = new();
    public List<Driver> Drivers = new();
    public int MaxDriverCapacity 
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

    public RaceTeam(string teamName, int maxDriverCapacity)
    {
        TeamName = teamName;
        MaxDriverCapacity = maxDriverCapacity;
    }

    Action<string> OnDriverAdded = name => Console.WriteLine($"Пилотът {name} се присъедини към {TeamName}!");

    public void AddDriver(Driver driver)
    {
        if(Drivers.Count < MaxDriverCapacity)
        {
            Drivers.Add(driver);
            OnDriverAdded(driver.Name);
        }
        else
            Console.WriteLine("Няма свободни места в отбора!");
    }
}
