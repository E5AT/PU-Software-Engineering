namespace ConsoleApp5.Online_Learning_Platform;

public class Enrollment
{
    public Student Student { get; set; }
    public Course Course { get; set; }
    public double PaidPrice { get; set; }
    public bool IsCompleted { get; set; }

    public Enrollment(Student student, Course course, double paidPrice, bool isCompleted)
    {
        Student = student;
        Course = course;
        PaidPrice = paidPrice;
        IsCompleted = isCompleted;
    }
}