namespace AirportFlightManagement;

public abstract class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }
}


public class Passenger : Person
{
    public string PassportNumber
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length != 10)
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public int Age 
    {
        get;
        set
        {
            if(value > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public Passenger(string name, string passportNumber, int age)
        : base(name)
    {
        PassportNumber = passportNumber;
        Age = age;
    }

}


public enum Role
{
    Pilot,
    Copilot,
    FlightAttendant
}

public class CrewMember : Person
{
    public Role Role{get; set; }

    public CrewMember(string name, Role role)
        : base(name)
    {
        Role = role;
    }
}

public class GroundEngineer : Person
{
    public string LicensePlate
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value) || value.Length != 6)
                throw new ArgumentNullException(nameof(value));

            field = value;
        }
    }

    public GroundEngineer(string name, string licensePlate)
        : base(name)
    {
        LicensePlate = licensePlate;
    }

}



public class Flight 
{
    public string FlightNumber { get; set; }
    public string Destination { get; set; }
    public Aircraft AssignedAircraft;
    public List<Passenger> Passengers;
    public List<CrewMember> Crew;

    public Action<string> OnPassengerBoarded;

    public Flight(string flightNumber, string destination, Aircraft aircraft)
    {
        FlightNumber = flightNumber;
        Destination = destination;
        AssignedAircraft = aircraft;

        Passengers = new();
        Crew = new();

        OnPassengerBoarded = name => Console.WriteLine($"Пътник {name} се качи на полет {FlightNumber}!");

    }

    public void BoardPassenger(Passenger passenger)
    {
        if(AssignedAircraft is CargoPlane)
            Console.WriteLine("Не може да се добави пътник в карго самолет!");
        else if(AssignedAircraft is PassengerPlane passengerPlane)
        {
            if(passengerPlane.PassengerCapacity > Passengers.Count)
            {
                Passengers.Add(passenger);
                OnPassengerBoarded(passenger.Name);
            }
            else
                Console.WriteLine("В самолета няма достатъчно места!");
        }
    }
}
