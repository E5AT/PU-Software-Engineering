using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.Second
{
  internal class Car:Vehicle
  {
    private int seats;
    public int Seats
    {
      get {  return seats; }
      set
      {
        if (value < 1 || value > 9)
          throw new ArgumentException();

        seats = value;
      }
    }

    public override string GetInfo()
    {
      return $"{base.GetInfo()} with {Seats} seat/s";
    }

    public override string GetVehicleType()
    {
      return "Car";
    }

    public Car(string brand, string model, int year, int seats) :base(brand, model, year)
    {
      Seats = seats;
    }
  }
}
