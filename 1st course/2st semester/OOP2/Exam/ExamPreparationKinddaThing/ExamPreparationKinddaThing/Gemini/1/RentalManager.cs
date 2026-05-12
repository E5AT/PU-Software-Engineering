using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparationKinddaThing.Gemini._1;

class RentalManager
{
    private List<Vehicle> vehicles;

    public void Add(Vehicle vehicle) =>
        vehicles.Add(
            vehicles.Contains(vehicle) || vehicle is null
                ? throw new ArgumentException()
                : vehicle);
    
    public void Remove(string regNum) =>
        vehicles.Remove(vehicles.FirstOrDefault(v => v.RegNum == regNum));
    
    public void Print() =>
        Console.WriteLine(string.Join(", ", vehicles.Select(v => v.GetInfo())));
    
    public double CalculatePrice(string regNum, int days) =>
        vehicles.FirstOrDefault(v => v.RegNum == regNum).CalculateRentalPrice(days);
    
    public void PrintCarsMoreThan5People() =>
        Console.WriteLine(string.Join(", ", vehicles.Where(v => v is Car && ((Car)v).CountPassengers>5).Select(v => v.GetInfo())));
    
    
}