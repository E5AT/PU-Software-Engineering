namespace ConsoleApp5;

public class Administrator : Employee
{
    private double fixedSalary;

    public override double Salary
    {
        get => fixedSalary;
        set;
    }

    public Administrator(string Name, double Salary)
        : base(Name) =>
            fixedSalary = Salary;
}