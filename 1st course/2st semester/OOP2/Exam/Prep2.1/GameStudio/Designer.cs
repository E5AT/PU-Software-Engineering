using System;

namespace GameStudio;

public class Designer : GameStudioPerson
{
    public string Software
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public Designer(string name, int experience, string software)
        : base(name, experience)
    {
        Software = software;
    }
}
