using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  internal class CustomQueue<T>
  {
    private List<T> queue;

    public int Count
    {
      get
      {
        return queue.Count;
      }
    }

    public T Head
    {
      get
      {
        return queue.ElementAt(0);
      }
    }

    public T Tail
    {
      get
      {
        return queue.ElementAt(Count - 1);
      }
    }

    public CustomQueue()
    {
      queue = new List<T>();
    }

    //Enqueue, Dequeue, Count
    public void Enqueue(T item)
    {
      queue.Add(item);
    }

    public T Dequeue()
    {
      T item = queue.ElementAt(0);
      queue.RemoveAt(0);
      return item;
    }


  }
}
