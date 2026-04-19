using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
  internal class Graph
  {
    private int[,] matrix { get; set; }

    public Graph(int n)
    {
      matrix = new int[n, n];
    }

    public void RemoveEdge(int from, int to)
    {
      matrix[from, to] = int.MaxValue;
    }

    public void AddEdge(int from, int to, int weight)
    {
      matrix[from, to] = weight;
    }

    public List<int> GetEdges(int edge)
    {
      List<int> edges = new List<int>();

      for (int i = 0; i < matrix.GetLength(1); i++)
        if (matrix[edge, i] != int.MaxValue)
          edges.Add(i);

      return edges;
    }

    public void BFS(int start)
    {
      bool[] visited = new bool[matrix.GetLength(0)];
      Queue<int> queue = new Queue<int>();

      visited[start] = true;
      queue.Enqueue(start);

      while (queue.Count != 0)
      {
        Console.WriteLine(queue.Peek());

        foreach (int edge in GetEdges(queue.Dequeue()))
        {
          if (!visited[edge])
          {
            queue.Enqueue(edge);
            visited[edge] = true;
          }
        }
      }
    }

    public int[] ShortestPath(int start)
    {
      int[] distances = new int[matrix.GetLength(0)];
      for (int i = 0; i < distances.Length; i++)
        distances[i] = int.MaxValue;

      bool[] visited = new bool[matrix.GetLength(0)];
      for (int i = 0; i < visited.Length; i++)
        visited[i] = false;

      distances[start] = 0;


      for (int count = 0; count < matrix.GetLength(0) - 1; count++)
      {
        int curr = -1;

        int min = int.MaxValue;

        for (int i = 0; i < distances.Length; i++)
          if (!visited[i] && min >= distances[i])
          {
            min = distances[i];
            curr = i;
          }

        visited[curr] = true;
        for (int i = 0; i < matrix.GetLength(0); i++)
          if (!visited[i]
              && matrix[curr, i] != int.MaxValue
              && distances[curr] != int.MaxValue
              && distances[curr] + matrix[curr, i] < distances[i])
            distances[i] = distances[curr] + matrix[curr, i];
      }

      return distances;
    }
  }
}
