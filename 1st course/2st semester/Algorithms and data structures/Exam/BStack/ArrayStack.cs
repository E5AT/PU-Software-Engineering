namespace Stack;

public class ArrayStack
{
    public int[] Elements;
    public int Top;
    public int Capacity;

    public ArrayStack(int size)
    {
        Capacity = size;
        Elements = new int[Capacity];
        Top = -1;
    }

    public void Push(int item)
    {
        if(Top == Capacity)
        {
            Console.Write("Stack Overflow!");
            return;
        }
        Top++;
        Elements[Top] = item;
    }

    public int Pop()
    {
        if(Top == -1)
        {
            Console.WriteLine("Stack Underflow!");
            return -1;
        }
        int value = Elements[Top];
        Top--;
        return value;
    }

    public int Peek()
    {
        if(Top == -1)
            return -1;
        return Elements[Top];
    }

}
