namespace ConsoleApp5.Online_Learning_Platform;

public class Instructor
{
    public string Name { get; set; }
    public string Specialty { get; set; }

    public double Salary
    {
        get;
        set
        {
            if (value > 0)
                field = value;
            else throw new ArgumentException("Salary must be greater than zero");
        }
    }

    public Instructor(string name, string specialty, double salary)
    {
        Name = name;
        Specialty = specialty;
        Salary = salary;
    }
}