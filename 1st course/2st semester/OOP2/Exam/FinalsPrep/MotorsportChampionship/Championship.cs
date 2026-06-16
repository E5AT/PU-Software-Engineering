namespace MotorsportChampionship;

public class Championship 
{
    public string Name { get; set; }
    public List<RaceTeam> Teams = new();
    public List<RaceEngineer> Engineers = new();

    public List<RaceCar> GetLightweightCars(double maxWeight)
    {
        return (from t in Teams
                from c in t.Cars
                where c.Weight < maxWeight
                select c).ToList();
    }

    public List<FormulaCar> GetFormulaCars()
    {
        return Teams.SelectMany(t => t.Cars)
                    .OfType<FormulaCar>()
                    .ToList();
    }

    public double GetAverageDriverAge()
    {
        return Teams.SelectMany(t => t.Drivers)
                    .Average(d => d.Age);
    }
}
