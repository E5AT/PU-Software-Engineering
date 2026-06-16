namespace HashTable;

public class Node
{
    public int Value;
    public Node Next;

    public Node(int value)
    {
        Value = value;
        Next = null;
    }
}

public class HashTable
{
    public Node[] Buckets;
    public int Size;

    public HashTable(int capacity)
    {
        Size = capacity;
        Buckets = new Node[Size];
    }

    public int Hash(int value)
    {
        return Math.Abs(value) % Size;
    }

    public void Insert(int value)
    {
        int index = Hash(value);
        Node newNode = new Node(value);

        if(Buckets[index] == null)
            Buckets[index] = newNode;
        else
        {
            newNode.Next = Buckets[index];
            Buckets[index] = newNode;
        }
    }

    public bool Search(int target)
    {
        int index = Hash(target);
        Node Current = Buckets[index];

        while(Current != null)
        {
            if(Current.Value == target)
                return true;

            Current = Current.Next;
        }

        return false;
    }

    public bool Remove(int value)
    {
        int index = Hash(value);
        Node Current = Buckets[index];
        Node Prev = null;

        while(Current != null)
        {
            if(Current.Value == value)
            {
                if(Prev == null)
                    Buckets[index] = Current.Next;
                else
                    Prev.Next = Current.Next;
                return true;
            }

            Prev = Current;
            Current = Current.Next;
        }

        return false;
    }
}
