namespace MotorsportChampionship;

public class FormulaCar : RaceCar, ITuneable
{
    public int AeroEfficiency { get; set; }

    public FormulaCar(string model, double weight, int aeroEfficiency)
        : base(model, weight)
    {
        AeroEfficiency = aeroEfficiency;
    }

    public void TuneEngine()
    {
        Console.WriteLine($"Formula car {Model} engine has been tuned!");
    }
}
