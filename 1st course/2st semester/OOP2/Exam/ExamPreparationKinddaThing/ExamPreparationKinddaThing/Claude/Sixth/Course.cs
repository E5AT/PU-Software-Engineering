using System;

namespace ExamPreparationKinddaThing.Sixth;

abstract class Course
{
    private string title;

    public string Title
    {
        get => title;
        set =>
            title =
                value.Length is >= 3
                    ? value
                    : throw new ArgumentException();
    }

    private int duration;

    public int Duration
    {
        get => duration;
        set =>
            duration =
                value is > 0
                    ? value
                    : throw new ArgumentException();
    }

    private double price;

    public double Price
    {
        get => price;
        set =>
            price =
                value is >= 0
                    ? value
                    : throw new ArgumentException();
    }

    public virtual string GetInfo() =>
        $"{Title} - {Duration} hours, {Price} cost";

    public abstract string GetType();
    
    public Course(string title, int duration, double price) =>
        (Title, Duration, Price) = (title, duration, price);
}