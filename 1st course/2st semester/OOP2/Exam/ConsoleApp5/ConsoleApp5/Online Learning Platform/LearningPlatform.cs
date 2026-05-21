namespace ConsoleApp5.Online_Learning_Platform;

public class LearningPlatform
{
    public string Name { get; set; }
    private List<Course> Courses;
    private List<Instructor> Instructors;
    private List<Student> Students;
    private List<Enrollment> Enrollments;
    private List<Certificate> Certificates;

    public double IncomeFromEnrollments
    {
        get { return Enrollments.Sum(e => e.PaidPrice); }
    }

    public double SalaryCosts
    {
        get { return Instructors.Sum(i => i.Salary); }
    }

    public int CompletedCoursesCount
    {
        get { return Courses.Count; }
    }

    public LearningPlatform(string name)
    {
        Name = name;
        Courses = new();
        Instructors = new();
        Students = new();
        Enrollments = new();
        Certificates = new();
    }
}