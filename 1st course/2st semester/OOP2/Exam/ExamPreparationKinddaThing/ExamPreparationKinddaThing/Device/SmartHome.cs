using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparationKinddaThing.Device;

class SmartHome
{
    private List<Room> rooms;

    public SmartHome() =>
        rooms = new();

    public void Add(Room room) =>
        rooms.Add(
            room is not null
                ? room
                : throw new Exception());

    public Room Search(string number)
    {
        Room r = rooms.FirstOrDefault(r => r.Number == number);

        if (r is null)
            throw new Exception();

        return r;
    }
    
    public void Remove(string number) =>
        rooms.Remove(Search(number));

    public void PrintAll()
    {
        foreach (Room room in rooms)
            room.PrintAll();
    }
}