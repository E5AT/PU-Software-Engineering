using System;

namespace FitLife;

public class Месечна : Карта
{
    public decimal ФиксиранаЦена
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

    public override decimal СмятайКрайнаЦена => ФиксиранаЦена;

    public Месечна(string сериенНомер, decimal фиксиранаЦена)
        : base(сериенНомер)
    {
        ФиксиранаЦена = фиксиранаЦена;
    }
}
