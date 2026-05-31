namespace University_System;

public class AdminStaff : Person
{
    public string Position
    {
        get;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Position cannot be null or empty!");
            field = value;
        }
    }


    public override double Salary
    {
        get;
        protected set
        {
            if (value is >= 0)
                field = value;
            else
                throw new ArgumentException("One cannot have negative salary!");
        }
    }

    public int WorkingHours
    {
        get;
        set
        {
            if(value is >= 0)
                field = value;
            else
                throw new ArgumentException("One cannot work negative hours!");
        }
    }

    public AdminStaff(string name, int age, string email, int id, string position, double salary, int workingHours)
        : base(name, age, email, id)
    {
        Position = position;
        Salary = salary;
        WorkingHours = workingHours;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Position: {Position}, Salary: ${Math.Round(Salary, 2)}, Working hours: {WorkingHours}";
    }
}