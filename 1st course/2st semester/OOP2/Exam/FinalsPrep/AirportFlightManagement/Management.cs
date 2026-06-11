namespace AirportFlightManagement;

public class Airport
{
    public string AirportName { get; set; }
    
    public List<Flight> Flights;
    public List<GroundEngineer> Engineers;

    public Airport(string name)
    {
        AirportName = name;
        
        Flights = new();
        Engineers = new();
    }

    public List<Flight> GetFlightsToDestination(string destination)
    {
        return (
                    from f in Flights
                    where f.Destination.Equals(destination)
                    select f
                ).ToList();
    }

    public List<CargoPlane> GetAssignedCargoPlanes()
    {
        return
            Flights
                .Select(f => f.AssignedAircraft)
                .OfType<CargoPlane>()
                .ToList();
    }

    public double GetAveragePassengerAge()
    {
        return
            Flights
                .SelectMany(f => f.Passengers)
                .Average(p => p.Age);
    }

}
