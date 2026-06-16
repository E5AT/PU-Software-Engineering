namespace ItemInventory
{
    public enum Rarity
    {
        Common,
        Rare,
        Legendary
    }

    public class Item
    {
       public int Id { get; set; }

       public string Name { get; set; }

       public double Price
       {
           get;
           set
           {
               if(value >= 0)
                field = value;
               else
                   throw new ArgumentOutOfRangeException(nameof(value));
           }
       }

       public Rarity Rarity {get; set;}

       public Item(int id, string name, double price, Rarity rarity)
       {
           Id = id;
           Name = name;
           Price = price;
           Rarity = rarity;
       }

       public override bool Equals(Object? obj)
       {
           if(obj is Item otherItem)
               return(this.Id == otherItem.Id);
           return false;
       }


    }
}
