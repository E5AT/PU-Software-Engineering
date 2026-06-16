namespace ItemInventory;

class Program
{
    static void Main(string[] args)
    {
        Item item1 = new(1, "Sword", 13.99, Rarity.Rare);
        Item item2 = new(1, "Shield", 10.00, Rarity.Common);

        Console.WriteLine($"item1 == item2: {item1 == item2}");
        Console.WriteLine($"item1.Equals(item2): {item1.Equals(item2)}");

        List<Item> inventory = new List<Item>
        {
            new Item(1, "Хилващ отвара", 15.5, Rarity.Common),
            new Item(2, "Мечът на краля", 250.0, Rarity.Legendary),
            new Item(3, "Щит от дракон", 180.0, Rarity.Legendary),
            new Item(4, "Счупен пръстен", 5.0, Rarity.Common),
            new Item(5, "Магически лък", 120.0, Rarity.Rare)
        };

        var task3Query = from i in inventory
                         where i.Rarity == Rarity.Legendary
                         orderby i.Price descending
                         select i.Name;

        var task3Lambda = inventory.Where(i => i.Rarity == Rarity.Legendary)
                                   .OrderByDescending( i => i.Price)
                                   .Select(i => i.Name);

        Predicate<Item> IsExpensive = item =>
            item.Price > 100;

        Action<Item> itemOperations = null;

        itemOperations += item => item.Price = item.Price * 0.9;
        itemOperations += item => Console.WriteLine($"Name: {item.Name}, Price: {Math.Round(item.Price, 2)}€");

        var magicBow = inventory.FirstOrDefault(i => i.Name.Equals("Магически лък"));
        if(magicBow is not null)
            itemOperations(magicBow);
    }
}
