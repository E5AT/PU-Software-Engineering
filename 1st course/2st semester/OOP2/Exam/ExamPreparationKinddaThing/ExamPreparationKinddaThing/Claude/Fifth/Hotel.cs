using System;
using System.Collections.Generic;
using System.Linq;

namespace ExamPreparationKinddaThing.Fifth;

class Hotel
{
    List<Room> rooms;

    public Hotel() =>
        rooms = new List<Room>();
    
    public void AddRoom(Room room) =>
        rooms.Add(
            room is not null
                ? room
                : throw new ArgumentNullException()
            );

    public bool RemoveByNumber(int number)
    {
        Room roomToRemove = rooms.FirstOrDefault(r => r.Number == number);
        
        if (roomToRemove is null)
            return false;
        
        rooms.Remove(roomToRemove);
        return true;
    }

    public Room SearchByNumber(int number) =>
        rooms.FirstOrDefault(r => r.Number == number);
    
    public void printAllRooms() =>
        Console.WriteLine(string.Join("\n",  rooms.Select(r => r.getInfo())));
    
    public Room CheapestRoom() =>
        rooms.OrderBy(r => r.PricePerNight).FirstOrDefault();
    
    public void printApartments() =>
        Console.WriteLine(string.Join("\n", rooms.Where(r => r.GetType().Equals("Apartment")).Select(a => a.getInfo())));
    
    public double ProfitForGivenNumOfNight(int num) =>
        rooms.Sum(r => r.PricePerNight * num);
    
    
}