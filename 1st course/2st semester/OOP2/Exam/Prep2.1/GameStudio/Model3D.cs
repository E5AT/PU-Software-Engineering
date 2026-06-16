using System;
using System.Drawing;

namespace GameStudio;

public class Model3D : GameAsset
{
    public int CountPolygons
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

    public Model3D(string name, int size, int countPolygons)
        : base(name, size)
    {
        CountPolygons = countPolygons;
    }
}
