namespace Queue;

public class CircularArrayQueue
{
    public int[] Elements;
    public int Front;
    public int Rear;
    public int Capacity;
    public int Count;

    public CircularArrayQueue(int size)
    {
        Capacity = size;
        Elements = new int[Capacity];
        Front = 0;
        Rear = -1;
        Count = 0;
    }

    public void Enqueue(int item)
    {
        if(Count == Capacity)
        {
            Console.WriteLine("Queue Overflow!");
            return;
        }

        Rear = (Rear + 1) % Capacity;
        Elements[Rear] = item;
        Count++;
    }

    public int Dequeue()
    {
        if(Count == 0)
        {
            Console.WriteLine("Queue Underflow!");
            return -1;
        }

        int value = Elements[Front];

        Front = (Front+1) % Capacity;
        Count--;
        return value;
    }
}
