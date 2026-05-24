using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  internal class LinkedListNode<T>
  {
    public T Value { get; set; }
    public LinkedListNode<T> Next { get; set; }
    public LinkedListNode<T> Prev { get; set; }

    public LinkedListNode(T value)
    {
      Value = value;
      Prev = null;
      Next = null;
    }


  }
}
