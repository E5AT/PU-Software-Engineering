namespace ConsoleApp5.Online_Learning_Platform;

public class Certificate
{
    public Student Student { get; set; }
    public Course Course { get; set; }
    public int Grade { get; set; }

    public Certificate(Student student, Course course, int grade)
    {
        Student = student;
        Course = course;
        Grade = grade;
    }
}