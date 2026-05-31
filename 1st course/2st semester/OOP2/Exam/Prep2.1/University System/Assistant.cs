namespace University_System;

public class Assistant : Person
{
    public int HoursPerWeek
    {
        get;
        set
        {
            if (value is >= 0)
                field = value;
            else
                throw new ArgumentException("One cannot work negative hours!");
        }
    }

    public bool IsPhDStudent { get; set; }

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

    public Assistant(string name, int age, string email, int id, int hoursPerWeek, bool isPhDStudent, double salary)
        : base(name, age, email, id)
    {
        HoursPerWeek = hoursPerWeek;
        IsPhDStudent = isPhDStudent;
        Salary = salary;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Hours per week: {HoursPerWeek}, Is PhD student: {(IsPhDStudent?"Yes":"No")}, Salary: ${Math.Round(Salary, 2)}";
    }
}