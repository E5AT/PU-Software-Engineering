using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Authentication.ExtendedProtection.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.Third
{
  abstract class Employee
  {
    private string name;
    public string Name
    {
      get { return name; }
      set
      {
        if (value.Length < 3)
          throw new ArgumentException();

        name = value;
      }
    }

    private string facNum;
    public string FacNum
    {
      get
      {
        return facNum;
      }
      set
      {
        if (value.Length < 4)
          throw new ArgumentException();

        facNum = value;
      }
    }

    private double salary;
    public double Salary
    {
      get
      {
        return salary;
      }
      set
      {
        if (value < 0)
          throw new ArgumentException();

        salary = value;
      }
    }

    public Employee(string name, string facNum, double salary)
    {
      Name = name;
      FacNum = facNum;
      Salary = salary;
    }

    public virtual string GetInfo()
    {
      return $"{Name}, {FacNum}, {Salary}$";
    }
  }
}
