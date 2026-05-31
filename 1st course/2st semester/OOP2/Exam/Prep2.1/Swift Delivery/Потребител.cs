using System.Runtime.ExceptionServices;

namespace Swift_Delivery;

public class Потребител
{
    public string Име
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Името не може да е празно!");
            else
                field = value;
        }
    }

    public string Егн
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException("Егн-то не може да е празо!");
            else if(value.Length != 10)
                throw new ArgumentException("Дължината на егн-то трябва да е точно 10 символа!");
            else
                field = value;
        }
    }

    public int Възраст
    {
        get;
        set
        {
            if(value >= 18)
                field = value;
            else
                throw new ArgumentException("Потребителят трябва да е пълнолетен!");
        }
    }

    public Потребител(string име, string егн, int възраст)
    {
        Име = име;
        Егн = егн;
        Възраст = възраст;
    }

    public override bool Equals(object? obj)
    {
        if(obj is Потребител другПотребител)
            return this.Егн == другПотребител.Егн;
        return false;
    }

    public override int GetHashCode()
    {
        return Егн.GetHashCode();
    }
}