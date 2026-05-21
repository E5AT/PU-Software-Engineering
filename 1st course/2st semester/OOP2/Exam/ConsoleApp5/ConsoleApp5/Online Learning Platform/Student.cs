namespace ConsoleApp5.Online_Learning_Platform;

public class Student
{
    public string Name { get; set; }
    public string Email { get; set; }

    public Student(string name, string email)
    {
        Name = name;
        Email = email;
    }
}