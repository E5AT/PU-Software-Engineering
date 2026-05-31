using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class School
  {
    List<ClassOfStudents> classOfStudents;
    
    public School(List<ClassOfStudents> classOfStudents)
    {
      this.classOfStudents = classOfStudents;
    }
  }

  class Commentable
  {
    private string optionalComment;
  }

  abstract class Person : Commentable
  {
    private string name;
    public Person(string name)
    {
      this.name = name;
    }
  }

  class Teacher : Person
  {
    List<Discipline> teachedDisciplines;
    public Teacher(string name, List<Discipline> teachedDisciplines) : base(name)
    {
      this.teachedDisciplines = teachedDisciplines;
    }
  }

  class Student : Person
  {
    private int classNum;
    public Student(string name, int classNum) : base(name)
    {
      this.classNum = classNum;
    }
  }

  class ClassOfStudents : Commentable
  {
    private string id;
    List<Teacher> teachers;

    public ClassOfStudents(string id, List<Teacher> teachers)
    {
      this.id = id;
      this.teachers = teachers;
    }
  }

  class Discipline : Commentable
  {
    private string name;
    private int numLectures, numExercises;
    public Discipline(string name, int numLectures, int numExercises)
    {
      this.name = name;
      this.numLectures = numLectures;
      this.numExercises = numExercises;
    }
  }
}
