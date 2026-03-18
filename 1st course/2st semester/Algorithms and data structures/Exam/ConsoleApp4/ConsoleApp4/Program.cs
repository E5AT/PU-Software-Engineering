using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //List
      List<int> list = new List<int>();
      list.Insert(0, 1);
      list.Add(2);
      list.Remove(2);
      list.RemoveAt(0);
      //list[0] = 3;

      CAL cal = new CAL();

      cal.Insert(0, 1);
      cal.print();
      cal.Add(2);
      cal.print();
      cal.Add(2);
      cal.print();
      Console.WriteLine(cal.IndexOf(2));
      cal.print();
      Console.WriteLine($"Removed element with index: {cal.Remove(2)}");
      Console.WriteLine($"Removed element with value: {cal.RemoveAt(2)}");
      cal.print();





      LinkedListNode<int> node1 = new LinkedListNode<int>(10);
      LinkedListNode<int> node2 = new LinkedListNode<int>(2);

      //node1.Next = node2;
      //node2.Prev = node1;


      LinkedList<int> l = new LinkedList<int>();

      // Adds at the end
      l.AddLast(10);
      // Adds at the beginning
      l.AddFirst(20);
      // Adds at the end
      l.AddLast(30);
      // Adds at the end
      l.AddLast(40);
    }
  }
}