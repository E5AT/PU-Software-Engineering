using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.Third
{
  internal class Programmer:Employee
  {
    private string programmingLanguage;
    public string ProgrammingLanguage
    {
      get { return programmingLanguage; }
      set
      {
        if (string.IsNullOrWhiteSpace(value))
          throw new ArgumentNullException();

        programmingLanguage = value;
      }
    }

    public Programmer(string name, string facNum, double salary, string programmingLanguage)
      :base(name, facNum, salary*1.1)
    {
      ProgrammingLanguage = programmingLanguage;
    }

    public override string GetInfo()
    {
      return $"{base.GetInfo()}, {ProgrammingLanguage}";
    }
  }
}
