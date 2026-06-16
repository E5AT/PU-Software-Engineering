namespace CodeJudge;

public class User
{
    public int Id {get;set;}
    public string Username
    {
        get;
        set
        {
            if(string.IsNullOrWhiteSpace(value))
                throw new ArgumentNullException(nameof(value));
            field = value;
        }
    }

    public User(int id, string username)
    {
        Id = id;
        Username = username;
    }

    public override string ToString()
    {
        return $"{Username} (ID: {Id})";
    }

    public override bool Equals(object? obj)
    {
        if(obj is User otherUser)
            return this.Username.Equals(otherUser.Username);
        return false;
    }
}
