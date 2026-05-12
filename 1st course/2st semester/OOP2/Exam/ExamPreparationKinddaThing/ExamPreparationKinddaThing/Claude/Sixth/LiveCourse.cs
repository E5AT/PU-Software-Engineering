using System;
using System.Diagnostics.PerformanceData;

namespace ExamPreparationKinddaThing.Sixth;

class LiveCourse : Course
{
    private int maxParticipants;

    public int MaxParticipants
    {
        get => maxParticipants;
        set =>
            maxParticipants =
                value is >= 2 and <= 100
                    ? value
                    : throw new ArgumentException();
    }

    private DateTime date;

    public DateTime Date
    {
         get => date;
         set =>
            date =
                value >= DateTime.Today
                    ? value
                    : throw new ArgumentException();
    }
    

    public override string GetInfo() =>
        $"{base.GetInfo()}, {MaxParticipants} capacity, will be holded in {Date}";

    public override string GetType() =>
        "LiveCourse";
    
    public LiveCourse(string title,  int duration, double price, int maxParticipants, DateTime date)
        : base(title, duration, price) =>
            (MaxParticipants, Date) = (maxParticipants, date);
}