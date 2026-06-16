namespace MotorsportChampionship;

public class Driver
{
    public string Name { get; set; }
    public int Age
    {
        get;
        set
        {
            if(value > 18)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public Driver(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
