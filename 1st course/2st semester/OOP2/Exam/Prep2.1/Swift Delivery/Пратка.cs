using Microsoft.VisualBasic.FileIO;

namespace Swift_Delivery;

public abstract class Пратка
{
    public string Име
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Името на пратката не може да бъде празна!");
            else
                field = value;
        }
    }

    public abstract double Цена{get;}
    public double Тегло // в кг
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentException("Теглото трябва да е положително!");
        }
    }

    public double Обем // в см^3
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentException("Обемът трябва да е положително!");
        }
    }

    public double Разстояние // в км
    {
        get;
        set
        {
            if(value is > 0)
                field = value;
            else
                throw new ArgumentException("Разстоянието трябва да е положително!");
        }
    }

    public Пратка(string име, double тегло, double обем, double разстояние)
    {
        Име = име;
        Тегло = тегло;
        Обем = обем;
        Разстояние = разстояние;
    }
}
