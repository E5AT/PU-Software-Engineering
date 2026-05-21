using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparationKinddaThing.Device;

class Room
{
    private string number;

    public string Number
    {
        get => number;
        set =>
            number =
                string.IsNullOrWhiteSpace(value)
                    ? throw new Exception()
                    : value;
    }
    
    List<Device> devices;

    public Room(string number) =>
        (devices, Number) = (new(), number);
    
    public void Add(Device d) =>
        devices.Add(
            d is not null
                ? d
                : throw new Exception()
            );

    public Device Search(string name)
    {
        Device d = devices.FirstOrDefault(d => d.Name == name);

        if (d is null)
            throw new Exception();

        return d;
    }
    
    public void Remove(string name) =>
        devices.Remove(Search(name));
    
    public void PrintAll() =>
        Console.WriteLine($"{Number} {string.Join("\n", devices.Select(d => d.GetInfo()))}");
}