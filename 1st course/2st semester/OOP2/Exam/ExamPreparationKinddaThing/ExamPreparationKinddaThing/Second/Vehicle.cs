using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.Second
{
  abstract class Vehicle
  {
    private string brand;
    public string Brand
    {
      get { return brand; }
      set
      {
        if (value.Length < 2)
          throw new ArgumentException();

        brand = value;
      }
    }

    private string model;
    public string Model
    {
      get { return model; }
      set
      {
        if (value.Length < 2)
          throw new ArgumentException();

        model = value;
      }
    }

    private int year;
    public int Year
    {
      get { return year; }
      set
      {
        if (value < 1886 || value > DateTime.Now.Year)
          throw new ArgumentException();

        year = value;
      }
    }

    public virtual string GetInfo()
    {
      return $"{Brand} {Model} ({Year})";
    }

    public abstract string GetVehicleType();

    public bool IsProducedAfter(int year)
    {
      return Year > year;
    }

    public Vehicle(string brand, string model,  int year)
    {
      Brand = brand;
      Model = model;
      Year = year;
    }
  }
}
