namespace Swift_Delivery;

public class Колет : Пратка, IДопълнителнаТакса
{
    public bool ЕЧуплива{get; set;}

    public double ИзчислиДопълнителнаТакса()
    {
        return ЕЧуплива ? 0.5 : 0;
    }

    public override double Цена // на практика работи, но никаква идея дали е устойчива...
                                // (прим. 1 кг * (50^3 / 50 000) = 1 * 2.5 = 2.5€)
    {
        get
        {
            return (Тегло * (Обем/50000)) + ИзчислиДопълнителнаТакса();
        }
    }

    public Колет(string име, double тегло, double обем, double разстояние, bool еЧуплива)
        : base(име, тегло, обем, разстояние)
    {
        this.ЕЧуплива = еЧуплива;
    }
}