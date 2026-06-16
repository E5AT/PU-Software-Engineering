namespace Stack;

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

public class ListStack
{
    public Node Top = null;

    public void Push(int item)
    {
        Node newNode = new Node(item);
        newNode.Next = Top;
        Top = newNode;
    }

    public int Pop()
    {
        if(Top == null)
        {
            Console.WriteLine("Stack Underflow!");
            return -1;
        }

        int value = Top.Value;
        Top = Top.Next;
        return value;
    }

    public int Peek()
    {
        if(Top == null)
            return -1;
        return Top.Value;
    }

    public bool IsEmpty()
    {
        return Top == null;
    }
}
