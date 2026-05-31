namespace Swift_Delivery;

public class Карго : Пратка, IДопълнителнаТакса
{
    public bool ЕЧуплива{get; set;}

    public double ИзчислиДопълнителнаТакса()
    {
        return ЕЧуплива ? 2 : 0;
    }

    public override double Цена // 2€ на 100 км
    {
        get
        {
            return ((Разстояние/100) * 2) + ИзчислиДопълнителнаТакса();
        }
    }

    public Карго(string име, double тегло, double обем, double разстояние, bool еЧуплива)
        : base(име, тегло, обем, разстояние)
    {
        this.ЕЧуплива = еЧуплива;
    }
}