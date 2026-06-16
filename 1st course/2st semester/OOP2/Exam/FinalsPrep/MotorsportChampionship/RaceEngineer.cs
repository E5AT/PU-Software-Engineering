namespace MotorsportChampionship;

public class RaceEngineer
{
    public string Name { get; set; }
    public string Specialization { get; set; }

    public RaceEngineer(string name, string specialization)
    {
        Name = name;
        Specialization = specialization;
    }
}
