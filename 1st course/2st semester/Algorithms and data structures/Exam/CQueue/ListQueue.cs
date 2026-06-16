namespace Queue;

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

public class ListQueue
{
    public Node Front = null;
    public Node Rear = null;

    public void Enqueue(int item)
    {
        Node newNode = new(item);

        if(Front == null)
        {
            Front = Rear = newNode;
            return;
        }

        Rear.Next = newNode;
        Rear = newNode;
    }

    public int Dequeue()
    {
        if(Front == null)
        {
            Console.WriteLine("Queue Underflow!");
            return -1;
        }

        int value = Front.Value;
        Front = Front.Next;

        if(Front == null) Rear = null;

        return value;

    }

    public int Peek()
    {
        if(Front == null)
            return -1;

        return Front.Value;
    }
}
