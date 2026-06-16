using System;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace FitLife;

public class Хъб
{
    Dictionary<string, Клиент> _клиенти = new();
    Dictionary<string, Карта> _активниКарти = new();
    private decimal _общПриход;

    public void ДобавиКлиент(Клиент клиент)
    {
        if(клиент is null)
            throw new ArgumentNullException(nameof(клиент));
        else if(_клиенти.ContainsKey(клиент.Имейл))
            throw new InvalidOperationException();
        
        _клиенти.Add(клиент.Имейл, клиент);
    }

    public void КупиКарта(string имейл, Карта карта)
    {
        if(имейл is null || карта is null)
            throw new ArgumentNullException();

        else if(!_клиенти.ContainsKey(имейл) || _активниКарти.ContainsKey(имейл))
            throw new InvalidOperationException();

        _активниКарти.Add(имейл, карта);
        _общПриход+=карта.СмятайКрайнаЦена;
    }

    public void Тренировка(string имейл)
    {
        if(имейл is null)
            throw new ArgumentNullException();
        else if(!_клиенти.ContainsKey(имейл) || !_активниКарти.ContainsKey(имейл))
            throw new InvalidOperationException();

        Карта карта = _активниКарти[имейл];
        if(карта is Слот)
        {
            ((Слот)карта).НамалиОставащПосещения(); // преди да се намали бройката, вътре в метода се проверява дали тя е валидна за посещения

            if(!((Слот)карта).МожеДаПосети)
                _активниКарти.Remove(имейл);
        }
    }

    public decimal ВземиОбщПриход => _общПриход;

    public List<Клиент> ТопNКлиента(int n)
    {
        return _активниКарти
                        .Where(c => c.Value is Слот)
                        .OrderByDescending(c => ((Слот)c.Value).ОставащПосещения)
                        .ThenBy(c => _клиенти[c.Key].Име)
                        .Select(c => _клиенти[c.Key])
                        .Take(n)
                        .ToList();

    }
}
