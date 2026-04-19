using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
  internal class Program
  {
    static void Main(string[] args)
    {
      //Graph graph = new Graph(6);

      //graph.AddEdge(0, 1, 5);
      //graph.AddEdge(0, 2, 4);
      //graph.AddEdge(0, 4, 2);

      //graph.AddEdge(1, 0, 5);
      //graph.AddEdge(1, 4, 3);
      //graph.AddEdge(1, 2, 3);
      //graph.AddEdge(1, 5, 5);

      //graph.AddEdge(2, 0, 4);
      //graph.AddEdge(2, 3, 8);

      //graph.AddEdge(3, 3, 6);

      //graph.AddEdge(4, 1, 8);
      //graph.AddEdge(4, 0, 5);

      //graph.AddEdge(5, 1, 3);

      //graph.BFS(0);

      Console.WriteLine(HashIndex("admin123"));
      Console.WriteLine(HashIndex("1"));
      Console.WriteLine(HashIndex(1));

      Console.WriteLine(HashIndexLambda("admin123"));
    }

    static int HashIndex(object x)
    {
      return Math.Abs(x.GetHashCode() % 64);
    }

    static Func<object, int> HashIndexLambda = (x) => Math.Abs(x.GetHashCode() % 64);
  }
}
