namespace ItemInventory
{
    static class InventoryExtensions
    {
        public static bool TryFindItem(this List<Item> items, int targetId, out Item foundItem)
        {
            Item item = items.FirstOrDefault(p => p.Id == targetId);

            if(item is null)
            {
                foundItem = null;
                return false;
            }
            else
            {
                foundItem = item;
                return true;
            }
        }
    }
}
