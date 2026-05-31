namespace ConsoleApp5;

public abstract class Employee
{
    public string Name
    {
        get;
        set =>
            field =
                string.IsNullOrWhiteSpace(value)
                    ? throw new ArgumentException("Name cannot be empty")
                    : value;
    }

    public abstract double Salary { get; set; }

    public Employee(string name) =>
        Name = name;
    
    public virtual void printInfo() =>
        Console.WriteLine($"Name: {Name}, Salary: {Salary}");
}