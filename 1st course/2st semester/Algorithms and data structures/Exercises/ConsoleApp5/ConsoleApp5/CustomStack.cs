using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  internal class CustomStack<T>
  {
    private T[] objects;
    public int index {  get; private set; }

    public CustomStack()
    {
      objects = new T[0];
      index = 0;
    }

    //Push, Pop, Peek
    public void Push(T el)
    {
      if (index >= objects.Length)
        Array.Resize(ref objects, index + 1);


      objects[index] = el;
      index++;
    }

    public T Pop()
    {
      T obj = objects[--index];
      objects[index] = default(T);
      return obj;
    }

    public T Peek()
    {
      return objects[index-1];
    }

    public void Empty()
    {
      objects = new T[1];
      index = 0;
    }
  }
}
