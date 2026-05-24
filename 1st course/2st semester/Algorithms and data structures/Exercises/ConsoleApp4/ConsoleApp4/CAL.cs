using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  internal class CAL
  {
      //int[] arr;
      //int count;

      private object[] arr;
      public int Count { get; set; }

      public CAL()
      {
        arr = new object[5];
        Count = 0;
      }

      public void Insert(int pos, object element)
      {
        //int el = arr[pos];
        //arr[pos] = (int)element;

        if (pos < 0 || pos > Count)
          throw new ArgumentOutOfRangeException();

        if (arr.Length == Count + 1)
        {
          object[] newArr = new object[arr.Length * 2];
          arr.CopyTo(newArr, 0);
          arr = newArr;
        }

        //Array.Resize(ref arr, arr.Length * 2);

        (arr[pos], element) = (element, arr[pos]);

        for (int i = pos + 1; i < arr.Length - 2; i++)
          (arr[i], element) = (element, arr[i + 1]);

        Count++;
      }

      public void Add(object el)
      {
        if (arr.Length == Count + 1)
        {
          Array.Resize(ref arr, arr.Length * 2);
        }

        for (int i = 0; i < arr.Length; i++)
          if (arr[i] == null)
          {
            arr[i] = el;
            break;
          }

        Count++;

        //Insert(Count, el);
      }

      public int IndexOf(object el)
      {
        for (int i = 0; i < Count; i++)
          if (arr[i].Equals(el))
            return i;
        return -1;
      }

      public int Remove(object el)
      {
        //int indexEl = IndexOf(el);

        //if(indexEl == -1) return -1;

        //arr[indexEl] = null;

        //return indexEl;

        object[] newArr = new object[Count];

        bool removed = false;
        int index = 0, removedIndex = -1;

        for (int i = 0; i < Count; i++)
          if (arr[i].Equals(el) && !removed)
          {
            removed = true;
            removedIndex = i;
          }
          else
          {
            newArr[index] = arr[i];
            index++;
          }

        arr = newArr;
        Count--;
        return removedIndex;
      }

      public object RemoveAt(int pos)
      {
        if (pos < 0)
          throw new ArgumentOutOfRangeException();

        object value = arr[pos];

        arr[pos] = null;

        Count--;

        return value;

        //object[] newArr = new object[Count];
        //Array.Copy(arr,newArr,)...


      }

      //indexer
      public object this[int index]
      {
        get
        {
          if (index >= Count || index < 0)
            throw new IndexOutOfRangeException("Invalid index");
          return arr[index];
        }
        set
        {
          if (index >= Count || index < 0)
            throw new IndexOutOfRangeException("Invalid index");

          arr[index] = value;
        }
      }

      public void print()
      {
        Console.WriteLine(string.Join(", ", arr));
      }
  }
}
