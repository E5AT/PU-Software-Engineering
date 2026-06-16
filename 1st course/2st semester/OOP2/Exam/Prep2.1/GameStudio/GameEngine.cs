using System;

namespace GameStudio;

public class GameEngine
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

    public int Capacity
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentOutOfRangeException(nameof(value));
        }
    }

    public GameEngine(string name, int capacity)
    {
        Name = name;
        Capacity = capacity;
    }
}
