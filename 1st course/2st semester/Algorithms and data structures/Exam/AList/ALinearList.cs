namespace List;

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

public class LinearList
{
    public Node Head;
    public int Count;

    public LinearList()
    {
        Head = null;
        Count = 0;
    }

    public void Add(int value)
    {
        if(Head == null)
            Head = new Node(value);

        else
        {
            Node current = Head;

            while(current.Next != null)
                current = current.Next;

            current.Next = new Node(value);
        }
        Count++;
    }

    public void PrintList()
    {
        Node current = Head;

        while(current != null)
        {
            Console.Write(current + " ");
            current = current.Next;
        }
    }

    public bool Contains(int target)
    {
        Node current = Head;

        while(current != null)
        {
            if(current.Value == target)
                return true;

            current = current.Next;
        }

        return false;
    }

    public bool Remove(int target)
    {
        if(Head == null) return false;

        if(Head.Value == target)
        {
            Head = Head.Next;
            Count--;
            return true;
        }

        Node current = Head;

        while(current.Next != null)
        {
            if(current.Next.Value == target)
            {
                current.Next = current.Next.Next;
                Count--;
                return true;
            }

            current = current.Next;
        }

        return false;
    }
}

