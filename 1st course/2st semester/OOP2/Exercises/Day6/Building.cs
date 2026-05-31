abstract class Room{
    public double Area{ get; set;}
    public string Color{get;set;}

    public Room(double area, string color){
        Area = area;
        Color = color;
    }
}

class Bathroom : Room{
    public Bathroom(double area, string color)
        : base(area, color){}
}

class Kitchen : Room {
    public Kitchen(double area, string color)
        : base(area, color){}
}

class Bedroom : Room {
    public Bedroom(double area, string color)
    : room(area, color) {}
}

class Person{
    public string Name{get; set;}

    public Person(string name){
        Name = name;
    }
}

abstract class Building{
    public abstract Area {get; set;}
    public double Height {get; set;}
    public string Color{get; set;}

    public Building(double height, string color){
        Area = area;
        Height = height;
        Color = color;
    }
}

class House : Building{
    private List<Room> Rooms;
    public override Area{
        get =>
            rooms.Sum(r => r.Area);
    }
    private Person Owner;

    public House(double height, string color, Person owner)
        : base(height, color){
            rooms = new();
            Owner = owner;
    }
}
