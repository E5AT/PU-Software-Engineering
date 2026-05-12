using System;
using System.Collections.Generic;
using System.Diagnostics.PerformanceData;
using System.Linq;

namespace ExamPreparationKinddaThing.Sixth;

class Platform
{
    private List<Course> courses;

    public Platform() =>
        courses = new List<Course>();

    public void AddCourse(Course course) =>
        courses.Add(
            course is not null
                ? course
                : throw new ArgumentNullException()
        );

    public bool RemoveCourse(string title)
    {
        Course courseToRemove = courses.FirstOrDefault(c => c.Title == title);

        if (courseToRemove is null)
            return false;
        
        courses.Remove(courseToRemove);
        return true;
    }
    
    public Course SearchByTitle(string title) =>
        courses.FirstOrDefault(c => c.Title == title);
    
    public void PrintAll() =>
        Console.WriteLine(string.Join("\n", courses.Select(c => c.GetInfo())));

    public void printFreeCourses() =>
        Console.WriteLine(string.Join("\n", courses.Where(c => c.Price == 0).Select(c => c.GetInfo())));
    
    public Course GetWithTheLongestDuration() =>
        courses.OrderByDescending(c => c.Duration).FirstOrDefault();
    
    public double GetTotalPriceSum() =>
        courses.Sum(c => c.Price);
}