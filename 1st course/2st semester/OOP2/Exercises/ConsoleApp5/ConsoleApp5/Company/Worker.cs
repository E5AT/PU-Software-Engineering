namespace ConsoleApp5;

public class Worker : Employee
{
    private double HourlyRate;
    private int WorkingHours;
    
    public override double Salary
    {
        get => HourlyRate * WorkingHours;
        set;
    }

    public Worker(string name, double hourlyRate, int workingHours)
        : base(name) =>
            (HourlyRate, WorkingHours) = (hourlyRate, workingHours);
}