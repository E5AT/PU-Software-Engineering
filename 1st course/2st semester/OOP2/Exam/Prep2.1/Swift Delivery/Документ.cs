using System.Security.Cryptography.X509Certificates;

namespace Swift_Delivery;

public class Документ : Пратка, IДопълнителнаТакса
{
    public double БазоваЦена
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentException("Базовата цена трябва да е положителна!");
        }
    }

    public bool ЕЕкспресна{get; set;}

    public double ИзчислиДопълнителнаТакса()
    {
        return ЕЕкспресна ? 1.2 : 1;
    }

    public override double Цена
    {
        get
        {
            return БазоваЦена * ИзчислиДопълнителнаТакса();
        }
    }

    public Документ(string име, double тегло, double обем, double разстояние, double базоваЦена, bool еЕкспресна)
        : base(име, тегло, обем, разстояние)
    {
        БазоваЦена = базоваЦена;
        this.ЕЕкспресна = еЕкспресна;
    }
}