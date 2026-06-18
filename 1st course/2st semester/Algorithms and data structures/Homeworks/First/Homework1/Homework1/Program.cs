using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
  internal class Program
  {
    //1. Задача
    static double[] enterArr(int n)
    {
      double[] arr = new double[n];

      for (int i = 0; i < n; i++)
      {
        Console.Write($"{i}. елемент: ");
        arr[i] = double.Parse(Console.ReadLine());
      }

      return arr;
    }

    static double sumOfFirstNEls(double[] arr, int n)
    {
      double sum = 0;

      for (int i = 0; i < n; i++)
        sum += arr[i];

      return sum;
    }

    static void first()
    {
      int n;
      double[] arr;

      while (true)
      {
        Console.Write("Въведете N (0 < N < 20): ");
        n = int.Parse(Console.ReadLine());
        if (0 < n && n < 20)
          break;
      }

      arr = enterArr(n);

      Console.WriteLine($"Сума на първите {n} елемента: {sumOfFirstNEls(arr, n)}");
    }

    //2. Задача
    static int[] randArr(int n)
    {
      int[] arr = new int[n];
      Random r = new Random();

      for (int i = 0; i < n; i++)
        arr[i] = r.Next(10, 100);

      return arr;
    }

    static void mostCommonEl(int[] arr)
    {
      int maxCount = 0, mostCommon = 0;

      for (int i = 0; i < arr.Length; i++)
      {
        int count = 0;

        for (int j = 0; j < arr.Length; j++)
          if (arr[j] == arr[i])
            count++;

        if (count > maxCount)
        {
          maxCount = count;
          mostCommon = arr[i];
        }
      }

      if (maxCount == 1)
        Console.WriteLine("Няма число, което се повтаря в масива!");
      else
        Console.WriteLine($"Най-често срещано число: {mostCommon} ({maxCount} пъти)");
    }

    static void second()
    {
      int n;
      int[] arr;

      Console.Write("\n\nВъведете N: "); n = int.Parse(Console.ReadLine());
      arr = randArr(n);
      Console.WriteLine($"Масив: {string.Join(", ", arr)}");
      mostCommonEl(arr);
    }


    //3. Задача
    static int[,] enterSquareMatrix(int n)
    {
      int[,] arr = new int[n, n];
      for (int i = 0; i < n; i++)
        for (int j = 0; j < n; j++)
        {
          Console.Write($"[{i},{j}] = ");
          int num = int.Parse(Console.ReadLine());
          while (num < 1 || num > 20)
          {
            Console.Write("Числото трябва да е в интервала [1..20]. Въведете отново: ");
            num = int.Parse(Console.ReadLine());
          }
          arr[i, j] = num;
        }

      return arr;
    }

    static bool magicSquare(int[,] arr)
    {
      int sum, targetSum = 0;

      for (int i = 0; i < arr.GetLength(0); i++)
        targetSum += arr[0, i];

      for (int i = 1; i < arr.GetLength(0); i++)
      {
        sum = 0;
        for (int j = 0; j < arr.GetLength(1); j++)
          sum += arr[i, j];

        if (sum != targetSum)
          return false;
      }

      for (int i = 0; i < arr.GetLength(1); i++)
      {
        sum = 0;
        for (int j = 0; j < arr.GetLength(0); j++)
          sum += arr[j, i];

        if (sum != targetSum)
          return false;
      }

      sum = 0;
      for (int i = 0; i < arr.GetLength(0); i++)
        sum += arr[i, i];

      if (sum != targetSum)
        return false;

      sum = 0;
      for (int i = 0; i < arr.GetLength(0); i++)
        sum += arr[i, arr.GetLength(0) - 1 - i];

      if (sum != targetSum)
        return false;

      return true;
    }

    static void third()
    {
      int n;
      int[,] arr;

      Console.Write("\n\nВъведете N: "); n = int.Parse(Console.ReadLine());
      arr = enterSquareMatrix(n);
      Console.WriteLine(magicSquare(arr) ? "Въведената матрица Е магически квадрат!" : "Въведената матрица НЕ Е магически квадрат");
    }
    static void Main(string[] args)
    {
      first();

      second();

      third();
    }
  }
}
