using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.First
{
  abstract class Animal
  {
    private string name;
    public string Name
    {
      get { return name; }
      set
      {
        if (value.Length < 2)
          throw new ArgumentException();
        name = value;
      }
    }

    private int age;
    public int Age
    {
      get { return age; }
      set
      {
        if (value < 0)
          throw new ArgumentException();

        age = value;
      }
    }

    public abstract string Sound();

    public virtual string GetInfo()
    {
      return $"Животно: {Name}, Възраст: {Age}";
    }

    public Animal(string name, int age)
    {
      Name = name;
      Age = age;
    }

  }
}
