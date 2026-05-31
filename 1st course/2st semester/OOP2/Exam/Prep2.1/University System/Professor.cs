namespace University_System;

public class Professor : Person
{
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

    public void UpdateSalary(double newSalary){
        Salary = newSalary;
    }

    public string Department
    {
        get;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Department cannot be null or empty!");
            field = value;
        }
    }
    public int YearsExperience
    {
        get;
        set
        {
            if(value is >= 0)
                field = value;
            else
                throw new ArgumentException("One cannot have experience of negative years!");
        }
    }

    public Professor(string name, int age, string email, int id, double salary, string department, int yearsExperience)
        : base(name, age, email, id)
    {
        Salary = salary;
        Department = department;
        YearsExperience = yearsExperience;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Salary: ${Math.Round(Salary, 2)}, Department: {Department}, Years of experience: {YearsExperience}";
    }
}