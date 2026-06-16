using System;

namespace GameStudio;

public abstract class GameStudioPerson
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

    public int Experience
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

    public GameStudioPerson(string name, int experience)
    {
        Name = name;
        Experience = experience;
    }
}
