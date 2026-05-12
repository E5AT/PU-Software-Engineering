using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.Second
{
  internal class Truck:Vehicle
  {
    private int capacity;
    public int Capacity
    {
      get { return capacity; }
      set
      {
        if (value < 0)
          throw new ArgumentException();

        capacity = value;
      }
    }

    public override string GetInfo()
    {
      return $"{base.GetInfo()} with {Capacity} tons of capacity";
    }

    public override string GetVehicleType()
    {
      return "Truck";
    }

    public Truck(string brand, string model, int year, int capacity):base(brand, model, year)
    {
      Capacity = capacity;
    }
  }
}
