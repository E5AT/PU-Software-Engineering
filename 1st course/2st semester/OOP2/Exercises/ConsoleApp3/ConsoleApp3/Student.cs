using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  internal class Student
  {
    private string name;
    public string Name
    {
      get { return name; }
      set
      {
        if (String.IsNullOrEmpty(value))
          throw new Exception("Name can't be null or empty!");

        name = value;
      }
    }

    private string facNum;
    public string FacNum
    {
      get { return facNum; }
      set
      {
        if (String.IsNullOrEmpty(value) || value.Length != 10)
          throw new Exception("The facNum must not be null or empty and be equal to 10 symbols!");

        facNum = value;
      }
    }

    private Dictionary<Subject, int> subjectsAndGrades;

    public Student(string name, string facNum)
    {
      Name = name;
      FacNum = facNum;
      subjectsAndGrades = new Dictionary<Subject, int>();
    }

    public void AddSubjectAndGrade(string subject, int grade)
    {
      Subject subjectToChange = subjectsAndGrades.Where(x => x.Key.Name == subject).Select(x => x.Key).First();

      if (subjectToChange == null)
        subjectsAndGrades.Add(new Subject(subject), grade);

      else
        subjectsAndGrades[subjectToChange] = grade;
    }

    public int CountOfSubjects()
    {
      return subjectsAndGrades.Count;
    }

    public List<Subject> ListOfSubjects()
    {
      return subjectsAndGrades.Select(x => x.Key).ToList();
    }

    public int GradeBySubject(string subject)
    {
      Subject Subject = subjectsAndGrades.Where(x => x.Key.Name == subject).Select(x => x.Key).First();

      if (Subject == null)
        throw new Exception("Cannot find this subject!");

      return subjectsAndGrades[Subject];
    }

    public double AverageGrade()
    {
      return (double)subjectsAndGrades.Sum(x => x.Value) / subjectsAndGrades.Count();
    }

    public void Print()
    {
      Console.WriteLine($"Name: {Name}\nFacNum: {FacNum}");
      foreach (KeyValuePair<Subject, int> subjectAndGrade in subjectsAndGrades)
      {
        Console.WriteLine(subjectAndGrade.Key + ": " + subjectAndGrade.Value);
      }
      Console.WriteLine($"Average: {Math.Round(AverageGrade(),1)}");
    }
  }
}
