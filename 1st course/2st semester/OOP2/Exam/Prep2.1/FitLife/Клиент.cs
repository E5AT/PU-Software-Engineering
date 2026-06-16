using System;

namespace FitLife;

public class Клиент
{
    public string Име
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public string Имейл
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentOutOfRangeException(nameof(value));
            field = value;
        }
    }

    public Клиент(string име, string имейл)
    {
        Име = име;
        Имейл = имейл;
    }

    // public override bool Equals(object? obj)
    // {
    //     if(obj is Клиент другКлиент)
    //         return this.Имейл.Equals(другКлиент.Имейл);
    //     return false;
    // }

    // public override int GetHashCode()
    // {
    //     return Имейл.GetHashCode();
    // }
    // Махнах ги, защото първоначалната ми идея беше да свържа Клиентите с Картите, но впоследствие се убедих, че е по-ефективно да свържа Имейла с Картата, в речник
}
