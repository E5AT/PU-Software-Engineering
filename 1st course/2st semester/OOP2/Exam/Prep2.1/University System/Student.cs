using System.Linq.Expressions;

namespace University_System;

public class Student : Person
{
    public string FacultyNumber
    {
        get;
        init
        {
            if (string.IsNullOrWhiteSpace(value))
                throw new ArgumentException("Faculty number cannot be empty!");
            field = value;
        }
    }

    public double AverageGrade
    {
        get;
        private set
        {
            if (value is >= 2 and <= 6)
                field = value;
            else
                throw new ArgumentException("Grade must be between 2 and 6!");
        }
    }

    public void UpdateAverageGrade(double newGrade){
        AverageGrade = newGrade;
    }

    public int Credits
    {
        get;
        private set
        {
            if(value is >= 0)
                field = value;
            else
                throw new ArgumentException("Credits cannot be negative!");
        }
    }

    public void UpdateCredits(int newCredits){
        Credits = newCredits;
    }
    
    public Student(string name, int age, string email, int id, string facNum, double avGrade, int credits)
        : base(name, age, email, id)
    {
        FacultyNumber = facNum;
        AverageGrade = avGrade;
        Credits = credits;
    }

    public override string GetInfo()
    {
        return $"{base.GetInfo()}, Faculty number: {FacultyNumber}, Average grade: {Math.Round(AverageGrade, 1)}, Credits: {Credits}";
    }
}