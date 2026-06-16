namespace FitLife;

public abstract class Карта
{
    public string СериенНомер
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public abstract decimal СмятайКрайнаЦена{get;}

    public Карта(string сериенНомер)
    {
        СериенНомер = сериенНомер;
    }
}
