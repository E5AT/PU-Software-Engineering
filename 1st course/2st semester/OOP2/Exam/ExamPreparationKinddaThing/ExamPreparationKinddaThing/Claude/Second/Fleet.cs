using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamPreparationKinddaThing.Second
{
  internal class Fleet
  {
    private List<Vehicle> vehicles;

    public Fleet()
    {
      vehicles = new List<Vehicle>();
    }

    public void Add(Vehicle vehicle)
    {
      if (vehicle == null)
        throw new ArgumentNullException();

      vehicles.Add(vehicle);
    }

    public bool Remove(string brand, string model)
    {
      Vehicle vehicleToRemove = vehicles.Where(v => v.Brand == brand && v.Model == model).FirstOrDefault();

      if (vehicleToRemove == null)
        return false;

      vehicles.Remove(vehicleToRemove);
      return true;
    }

    public List<Vehicle> Search(string brand)
    {
      return vehicles.Where(v => v.Brand == brand).ToList();
    }

    public void PrintAll()
    {
      foreach (Vehicle vehicle in vehicles)
        Console.WriteLine(vehicle.GetInfo());
    }

    public int TotalSeats()
    {
      return vehicles.Where(v => v.GetVehicleType() == "Car").Select(c => ((Car)c).Seats).Sum();
    }

    public int CountProducedAfter(int year)
    {
      return vehicles.Count(v => v.IsProducedAfter(year));
    }
  }
}
