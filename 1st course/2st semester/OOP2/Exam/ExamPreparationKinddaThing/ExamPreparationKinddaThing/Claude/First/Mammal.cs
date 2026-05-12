using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.First
{
  internal class Mammal:Animal
  {
    private string furColor;
    public string FurColor
    {
      get { return furColor; }
      set
      {
        if (value == null)
          furColor = value;
      }
    }

    public override string Sound()
    {
      return "*Whispers: Im a mammal...*";
    }

    public override string GetInfo()
    {
      return $"{base.GetInfo()}, Цвят на козината: {FurColor}";
    }

    public Mammal(string name, int age, string furColor) : base(name,age)
    {
      FurColor = furColor;
    }
  }
}
