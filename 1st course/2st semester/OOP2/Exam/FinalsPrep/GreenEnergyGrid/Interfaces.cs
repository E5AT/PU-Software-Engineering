namespace GreenEnergyGrid;


public interface IEnergyGenerator
{
    public double CalculateCurrentOutput();
}

public interface IStorable
{
    public bool StoreExcessEnergy(double energyAmount, out string logMessage);
}
