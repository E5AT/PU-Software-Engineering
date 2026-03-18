using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  internal class CustomLinkedList<T>
  {
    public int Count {  get; set; }
    LinkedListNode<T> First { get; set; }
    LinkedListNode<T> Last { get; set; }

    public CustomLinkedList()
    {
      Count = 0;
      First = null;
      Last = null;
    }

    public void AddFirst(T item)
    {
      if (First == null)
        First = new LinkedListNode<T>(item);

      LinkedListNode<T> newFirst = new LinkedListNode<T>(item);
      newFirst.Prev = null;
      newFirst.Next = First;

      First = newFirst;
      Count++;
    }

    public void AddLast(T item)
    {
      if(Last == null)
        Last = new LinkedListNode<T>(item);

      LinkedListNode<T> newLast = new LinkedListNode<T>(item);
      newLast.Prev = Last;
      newLast.Next = null;

      Last = newLast;
      Count++;
    }

    public void RemoveFirst(T item)
    {
      if(Count<=0)
        throw new InvalidOperationException();

      if (Count == 1)
        First = Last = null;

      else
      {
        First = First.Next;
        First.Prev = null;
      }
      Count--;
    }

    public void RemoveLast(T item){
      if (Count <= 0)
        throw new InvalidOperationException();

      if (Count == 1)
        First = Last = null;

      else
      {
        Last = Last.Prev;
        Last.Next = null;
      }
      Count--;
    }

    public void Remove(T item)
    {
      LinkedListNode<T> current = First;

      while(current!= null)
      {
        if(current.Equals(item))
        {
          current.Prev.Next = current.Next;
          current.Next.Prev = current.Prev;
          Count--;
          break;
        }
        current = current.Next;
      }

    }
  }
}
