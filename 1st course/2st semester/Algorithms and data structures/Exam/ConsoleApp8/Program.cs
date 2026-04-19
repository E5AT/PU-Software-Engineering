using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
  internal class Program
  {
    //0 - blank
    //1 - fresh
    //2 - rotten
    static int Oranges(int[,] oranges)
    {
      int minutes, freshOnes;
      minutes = freshOnes = 0;

      Queue<int> queue = new Queue<int>();

      for (int i = 0; i < oranges.GetLength(0); i++)
        for (int j = 0; j < oranges.GetLength(1); j++)
        {
          if (oranges[i, j] == 1)
            freshOnes++;

          queue.Enqueue(oranges[i,j]);
        }

      while (true)
      {

      }
    }

    static void Main(string[] args)
    {
    }
  }
}
