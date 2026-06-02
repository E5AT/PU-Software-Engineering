using System;

namespace TechSpace;

public class Client
{
    public string Email
    {
        get;
        init
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Email cannot be null!");
            else
                field = value;
        }
    }

    public string Name
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value), "Name cannot be null!");
            else
                field = value;
        }
    }

    public Client(string email, string name)
    {
        Email = email;
        Name = name;
    }

    public override bool Equals(object? obj)
    {
        if(obj is Client otherClient)
            return this.Email == otherClient.Email;
        return false;
    }

    public override int GetHashCode()
    {
        return Email.GetHashCode();
    }
}
