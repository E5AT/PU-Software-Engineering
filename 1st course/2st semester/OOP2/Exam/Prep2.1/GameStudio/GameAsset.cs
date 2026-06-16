namespace GameStudio;

public abstract class GameAsset
{
    public string Name
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public double Size // in MBs
    {
        get;
        set
        {
            if(value is >= 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public GameAsset(string name, double size)
    {
        Name = name;
        Size = size;
    }
}
