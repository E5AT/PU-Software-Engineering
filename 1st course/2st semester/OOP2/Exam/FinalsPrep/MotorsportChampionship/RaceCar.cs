namespace MotorsportChampionship;

public abstract class RaceCar
{
    public string Model{ get; set; }
    public double Weight
    {
        get;
        set
        {
            if(value > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException();
        }
    }

    public RaceCar(string model, double weight)
    {
        Model = model;
        Weight = weight;
    }
}
