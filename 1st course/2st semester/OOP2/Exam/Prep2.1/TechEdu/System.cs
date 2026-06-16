using System;

namespace TechEdu;

public class System
{
    private readonly Dictionary<string, EducationFormat> courses = new();
    private readonly Dictionary<string, Student> students = new();
    private readonly Dictionary<Student, EducationFormat> activeCourses = new();

    public void CreateCourse(EducationFormat course)
    {
        if(course is null)
            throw new ArgumentNullException(nameof(course), "Course cannot be null!");
        else if(courses.ContainsKey(course.Code))
            throw new InvalidOperationException($"Course with the code {course.Code} already exists!");
        else
            courses.Add(course.Code, course);
    }

    public void CreateStudent(Student student)
    {
        if(student is null)
            throw new ArgumentNullException(nameof(student), "Student cannot be null!");
        else if(students.ContainsKey(student.Email))
            throw new InvalidOperationException($"Student with the email {student.Email} already exists!");
        else
            students.Add(student.Email, student);
    }

    public void EnrollStudent(string email, string code)
    {
        if(!students.ContainsKey(email))
            throw new InvalidOperationException($"Cannot find student with the email {email}");
        else if(!courses.ContainsKey(code))
            throw new InvalidOperationException($"Cannot find course with the code {code}");

        Student student = students[email];
        if(activeCourses.ContainsKey(student))
            throw new InvalidOperationException($"Student with the email {email} is already enrolled to another course!");

        EducationFormat course = courses[code];
        
        if(course is Live)
            if (((Live)course).HasFreeSpaces)
            {
                ((Live)course).IncreaseCurrentCount();
                activeCourses.Add(student, course);
            }
            else
                throw new InvalidOperationException($"Course with the code {code} has already hit it's maximum capacity!");
        else
            activeCourses.Add(student, course);
    }

    public void FinishCourse(string email, string code, double grade)
    {
        if(grade is < 2.00 or > 6.00)
            throw new ArgumentOutOfRangeException(nameof(grade), "Invalid grade! It must be between 2.00 and 6.00!");
        else if(!students.ContainsKey(email))
            throw new InvalidOperationException($"Cannot find student with the email {email}");
        else if(!courses.ContainsKey(code))
            throw new InvalidOperationException($"Cannot find course with the code {code}");

        Student student = students[email];
        if(!activeCourses.ContainsKey(student))
            throw new InvalidOperationException($"Student with the email {email} currently is free!");

        EducationFormat course = courses[code];
        
        if(course is Live)
            ((Live)course).DecreaseCount();
        
        activeCourses.Remove(student);
        student.AddGrade(course, grade);
    }

    public decimal GetTotalExcpectedProfit()
    {
        return activeCourses.Values.Sum(c => c.CalculatePrice);
    }

    public List<Student> GetTopNStudents(int n)
    {
        if(n<=0)
            throw new ArgumentOutOfRangeException($"N({n}) must be positive!");
        else if(n>=students.Count)
            throw new ArgumentOutOfRangeException($"N({n}) is greater than students count({students.Count})");
        
        return students.Values.OrderByDescending(s => s.GetAverageGrade()).ThenBy(s => s.Name).Take(n).ToList();
    }
}
