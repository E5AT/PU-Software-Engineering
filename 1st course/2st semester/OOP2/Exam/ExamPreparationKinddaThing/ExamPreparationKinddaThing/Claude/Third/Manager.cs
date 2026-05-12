using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.Third
{
  internal class Manager:Employee
  {
    private int countWorkers;
    public int CountWorkers
    {
      get { return countWorkers; } 
      set
      {
        if (value < 1)
          throw new ArgumentException();

        countWorkers = value;
      }
    }

    public Manager(string name, string facNum, double salary, int countWorkers)
      :base(name, facNum, salary*1.2)
    {
      CountWorkers = countWorkers;
    }

    public override string GetInfo()
    {
      return $"{base.GetInfo()}, {countWorkers} workers";
    }
  }
}
