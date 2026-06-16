using System;

namespace FitLife;

public class Слот : Карта
{
    public decimal ЦенаТренировка
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

    public int ОбщПосещения
    {
        get;
        set
        {
            if(value is not > 0)
                throw new ArgumentOutOfRangeException(nameof(value));
            field = value;
            ОставащПосещения = ОбщПосещения;
        }
    }

    public int ОставащПосещения{get; private set;}
    public void НамалиОставащПосещения()
    {
        if (МожеДаПосети)
            ОставащПосещения--;
        else
            throw new InvalidOperationException();
    }

    public bool МожеДаПосети => !(ОставащПосещения == 0);

    public override decimal СмятайКрайнаЦена => ОбщПосещения * ЦенаТренировка;

    public Слот(string сериенНомер, decimal ценаТренировка, int общПосещения)
        : base(сериенНомер)
    {
        ЦенаТренировка = ценаТренировка;
        ОбщПосещения = общПосещения;
    }
}
