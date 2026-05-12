using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.First
{
  internal class Bird:Animal
  {
    private double wingSpan;
    public double WingSpan
    {
      get
      {
        return wingSpan;
      }
      set
      {
        if (value < 0)
          throw new ArgumentException();

        wingSpan = value;
      }
    }

    private bool canFly;
    public bool CanFly
    {
      get { return canFly; }
      set
      {
        canFly = value;
      }
    }

    public override string Sound()
    {
      return "*Im a biiird :>>>*";
    }

    public override string GetInfo()
    {
      return $"{base.GetInfo()}, Крилете...: {WingSpan}, Може да лети: {canFly}";
    }

    public Bird(string name, int age, double wingSpan,  bool canFly) : base(name, age)
    {
      WingSpan = wingSpan;
      CanFly = canFly;
    }
  }
}
