using System;
using System.Linq.Expressions;

namespace GameStudio;

public class Soundtrack : GameAsset
{
    public int Duration // in secs
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

    public Soundtrack(string name, double size, int duration)
        :base(name, size)
    {
        Duration = duration;
    }
}
