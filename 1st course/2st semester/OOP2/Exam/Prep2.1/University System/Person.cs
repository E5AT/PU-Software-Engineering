namespace University_System;

public abstract class Person
{
    public string Name
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Name cannot be null or white space!");
            else
                field = value;
        }
    }
    public int Age
    {
        get;
        init
        {
            if(value is >= 0)
                field = value;
            else
                throw new ArgumentException("One cannot be negative years old!");
        }
    }
    public string Email
    {
        get;
        set
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Email cannot be null or whitespace!");
            field = value;
        }
    }
    public int Id { get; init; }

    public virtual double Salary { get; protected set; } // to avoid type checking inside of University

    public Person(string name, int age, string email, int id)
    {
        Name = name;
        Age = age;
        Email = email;
        Id = id;
    }

    public virtual string GetInfo()
    {
        return $"Name: {Name}, Age: {Age}, Email: {Email}, Id: {Id}";
    }
}
