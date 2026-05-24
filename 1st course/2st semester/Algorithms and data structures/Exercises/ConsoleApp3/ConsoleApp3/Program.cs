using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  internal class Program
  {

    static int Factorial(int n)
    {
      if (n == 0)
        return 1;
      else
        return n * Factorial(n - 1);
    }

    //O(2ⁿ)
    static int fib(int n)
    {
      if (n == 0)
        return 0;

      else if (n == 1)
        return 1;

      else
        return fib(n - 1) + fib(n - 2);
    }

    //O(n)
    static long iterFib(int n)
    {
      List<long> nums = new List<long>();
      nums.Add(0);
      nums.Add(1);

      for (int i = 2; i < n; i++)
        nums.Add(nums.ElementAt(i - 1) + nums.ElementAt(i - 2));

      return nums.Last();
    }

    static int RecNOD(int a, int b)
    {
      if (b == 0)
        return a;

      return RecNOD(b, a % b);
    }

    static int IteNOD(int a, int b)
    {
      while (b != 0)
        (a, b) = (b, a % b);
      //  int temp = a % b;
      //  a = b;
      //  b = temp;

      return a;
    }

    static int[] RecQuickSort(int[] arr, int left, int right)
    {
      if (left < right)
      {
        int p = Partition(arr, left, right);

        return RecQuickSort(arr, left, p - 1).Concat(RecQuickSort(arr, p + 1, right)).ToArray();
      }
      return new int[] { };
    }

    static int Partition(int[] arr, int left, int right)
    {
      int pivot = arr[right];
      int i = left - 1;

      for (int j = left; j < right; j++)
        if (arr[j] <= pivot)
        {
          i++;
          (arr[i], arr[j]) = (arr[j], arr[i]);
        }

      (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);

      return i + 1;
    }

    static int BogoSort(int[] arr)
    {
      Random r = new Random();
      int[] arr1 = new int[arr.Length];
      int count = 0;
      do
      {
        List<int> indexes = new List<int>();

        foreach (int i in arr)
        {
          count++;
          int rand = r.Next(arr.Length);
          while (indexes.Contains(rand))
          {
            count++;
            rand = r.Next(arr.Length);
          }

          arr1[rand] = i;
          indexes.Add(rand);
        }
      } while (!Sorted(arr1));

      return count;
    }

    static bool Sorted(int[] arr)
    {
      for (int i = 0; i < arr.Length - 1; i++)
        if (arr[i] > arr[i + 1])
          return false;
      return true;
    }
    
    //static int MergerSort(...)
    //{
    //  ...
    //}

    static void Main(string[] args)
    {
      for (int i = 0; i < 10; i++)
        Console.WriteLine($"{i}! = {Factorial(i)}");

      Console.WriteLine();

      for (int i = 0; i < 10; i++)
        Console.WriteLine($"{i} = {fib(i)}");

      Console.WriteLine(iterFib(50));


      Console.WriteLine(RecNOD(50, 10));
      Console.WriteLine(IteNOD(50, 5));

      Console.WriteLine("Bogo sort: " + BogoSort(new int[] { 2, 6, 7, 1, 2, 2, 5, 8, 0, 9, 13, 1 }).ToString("N0"));
    }
  }
}
