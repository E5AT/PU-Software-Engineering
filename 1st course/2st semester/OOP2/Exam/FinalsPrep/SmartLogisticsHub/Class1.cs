namespace SmartLogisticsHub;

public record CargoItem(string TrackingNumber, double Weight);

public interface IIdentifiable
{
    public string Id { get; }
}

public class HighValueComponent : IIdentifiable
{
    public string Id 
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public double ValueInEuro
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

    public HighValueComponent(string id, double valueInEuro)
    {
        Id = id;
        ValueInEuro = valueInEuro;
    }
}

public class SecureVault<T> where T : IIdentifiable
{
    public int Capacity
    {
        get;
        init
        {
            if(value > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public List<T> Items;

    public SecureVault(int capacity)
    {
        Capacity = capacity;
        Items = new();
    }

    public bool StoreItem(T item)
    {
        if(Items.Count < Capacity)
        {
            Items.Add(item);
            return true;
        }
        return false;
    }

    public T FindById(string Id)
    {
        return Items.FirstOrDefault(i => i.Id.Equals(Id));
    }
}

public class LogisticsManager
{
    public List<CargoItem> GeneralCargo;
    public SecureVault<HighValueComponent> HighValueVault;

    public LogisticsManager()
    {
        GeneralCargo = new();
        HighValueVault = new(5);
    }

    public List<CargoItem> GetHeaviestCargoItems(int topCount)
    {
        return (GeneralCargo.OrderByDescending(c => c.Weight)
                           .Take(topCount))
                           .ToList();
    }

    public IEnumerable<object> GetCargoSummaryQuery()
    {
        return from c in GeneralCargo
               select new
               {
                   Code = c.TrackingNumber.ToUpper(),
                   IsHeavy = c.Weight > 100
               };
    }
}
