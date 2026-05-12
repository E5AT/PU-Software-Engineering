using System;
using System.Diagnostics.PerformanceData;

namespace ExamPreparationKinddaThing.Sixth;

class VideoCourse : Course
{
    private int countVideo;

    public int CountVideo
    {
        get => countVideo;
        set =>
            countVideo =
                value is > 0
                    ? value
                    : throw new ArgumentException();
    }

    public override string GetInfo() =>
        $"{base.GetInfo()}, {CountVideo} videos";

    public override string GetType() =>
        "VideoCourse";
    
    public VideoCourse(string title, int duration, double price, int countVideo)
        : base(title, duration, price) =>
            CountVideo = countVideo;
}