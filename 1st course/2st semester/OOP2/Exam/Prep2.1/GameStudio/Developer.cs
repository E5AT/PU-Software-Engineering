using System;

namespace GameStudio;

public class Developer : GameStudioPerson
{
    public string ProgrammingLanguage{
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public Developer(string name, int experience, string programmingLanguage)
        :base(name, experience)
    {
        ProgrammingLanguage = programmingLanguage;
    }
}
