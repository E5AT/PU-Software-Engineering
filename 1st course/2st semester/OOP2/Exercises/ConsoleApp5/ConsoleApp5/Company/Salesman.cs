namespace ConsoleApp5;

public class Salesman : Employee
{
    private double Commision;
    private double BaseSalary;
    
    public override double Salary
    {
        get => BaseSalary * Commision;
        set;
    }

    public Salesman(string name, double baseSalary, double commission)
        : base(name)
    {
        BaseSalary = baseSalary;
        Commision = commission;
    }
}