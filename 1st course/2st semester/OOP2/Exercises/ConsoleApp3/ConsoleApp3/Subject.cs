using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  internal class Subject
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

    public Subject(string name)
    {
      Name = name;
    }
  }




}
