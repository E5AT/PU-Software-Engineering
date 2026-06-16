namespace GreenEnergyGrid;

public class GridController
{
    public List<PowerPlant> ConnectedPlants;

    public GridController()
    {
        ConnectedPlants = new();
    }

    public List<string> GetHighYieldPlantNames(double minOutput)
    {
        return (from plant in ConnectedPlants
                where plant is IEnergyGenerator
                let generator = plant as IEnergyGenerator
                where generator.CalculateCurrentOutput() > minOutput
                select plant.Name).ToList();
    }

    public double GetTotalStoredEnergy()
    {
        return ConnectedPlants.OfType<WindPlant>()
                              .Sum(plant => plant.CurrentStoredEnergy);
    }

    public IEnumerable<object> GetGridSummaryQuery()
    {
        return from plant in ConnectedPlants
               where plant is IEnergyGenerator
               select new
               {
                   PlantName = plant.Name.ToUpper(),
                   IsHighlyEfficient = plant.Efficiency > 0.8
               };
    }

    public Dictionary<bool, int> GetCapacityReportByStorage()
    {
        return ConnectedPlants.GroupBy(plant => plant is IStorable)
                              .ToDictionary(group => group.Key, group => group.Count());
    }
}
