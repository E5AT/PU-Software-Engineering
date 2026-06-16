using System;
using System.Runtime.ExceptionServices;

namespace TechEdu;

public class Student
{
    public string Name
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            else
                field = value;
        }
    }

    public string Email
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Email cannot be null!");
            else
                field = value;
        }
    }

    public override bool Equals(object? obj)
    {
        if(obj is Student otherStudent)
            return this.Email == otherStudent.Email;
        return false;
    }

    public override int GetHashCode()
    {
        return Email.GetHashCode();
    }

    private readonly Dictionary<EducationFormat, double> Grades = new();

    public Student(string name, string email)
    {
        Name = name;
        Email = email;
    }

    public void AddGrade(EducationFormat course, double grade)
    {
        if(course is null)
            throw new InvalidOperationException("Cannot add null course!");
        else if(grade is <2 or >6)
            throw new ArgumentOutOfRangeException("Grade is not in the allowed [2, 6]");

        Grades.Add(course, grade);
    }

    public double GetAverageGrade()
    {
        if(Grades.Count==0)
            return 0;
        return Grades.Values.Average();
    }

}
