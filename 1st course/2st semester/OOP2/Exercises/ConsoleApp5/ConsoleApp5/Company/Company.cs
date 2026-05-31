namespace ConsoleApp5;

public class Company
{
    public string Name { get; set; }
    private List<Employee> employees;
    
    public Company(string name) =>
        (Name, employees) = (name, new());
    
    public double SalaryCost() =>
        employees.Sum(e => e.Salary);
    
    public void Add(Employee employee) =>
        employees.Add(employee);
    
    public void Remove(Employee employee) =>
        employees.Remove(employee);
}