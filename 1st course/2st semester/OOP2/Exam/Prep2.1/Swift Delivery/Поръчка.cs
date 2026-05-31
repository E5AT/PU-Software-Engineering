using System.ComponentModel;
using System.Net.Http.Headers;
using Microsoft.VisualBasic.FileIO;

namespace Swift_Delivery;

public enum СтатусПоръчка
{
    Приета,
    ВТранзит,
    Доставена
}

public class Поръчка
{
    public Пратка пратка
    {
        get;
        set
        {
            if(value == null)
                throw new ArgumentNullException("Пратката не може да бъде null!");
            else
                field = value;
        }
    }

    public DateTime Дата
    {
        get;
        set
        {
            if(value <= DateTime.Today)
                field = value;
            else
                throw new ArgumentException("Датата не може да е бъдеща!");
        }
    }

    public СтатусПоръчка Статус{get; private set;}

    public void ПромениСтатус(СтатусПоръчка новСтатус)
    {
        switch (новСтатус)
        {
            case СтатусПоръчка.ВТранзит:
                if(Статус == СтатусПоръчка.Приета)
                    Статус = новСтатус;
                else
                    throw new ArgumentException("За да променим статуса на \"в транзит\", той първо трябва да е \"приета\"!");
                break;
            case СтатусПоръчка.Доставена:
                if(Статус == СтатусПоръчка.Приета || Статус == СтатусПоръчка.ВТранзит)
                    Статус = новСтатус;
                else
                    throw new ArgumentException("За да променим статуса на \"доставена\", той първо трябва да е \"приета\" или \"в транзит\"!");
                break;
            default:
                Статус = новСтатус; // статусът или е "приета" или не е от позволеното множество, property-то ще се погрижи за проверката и за хвърлянето на изключение
                break;
        }
    }

    public string Номер
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Номерът не може да е празно");
            else
                field = value;
        }
    }

    public Поръчка(Пратка пратка, string номер)
    {
        this.пратка = пратка;
        Дата = DateTime.Today;
        Статус = СтатусПоръчка.Приета; // самия факт, че тази пратка се регистрира тука е признак, че тя е "приета"...
        Номер = номер;
    }

    public Поръчка(Пратка пратка, DateTime дата, СтатусПоръчка статус, string номер)
    {
        this.пратка = пратка;
        Дата = дата;
        Статус = статус;
        Номер = номер;
    }

    public double Стойност
    {
        get => пратка.Цена;
    }
}