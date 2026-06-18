using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
  internal class Program
  {
    //1. Задача
    static bool IsMonoIncreasing(double[] arr, int index)
    {
      if (index >= arr.Length - 1)
        return true;

      if (arr[index] > arr[index + 1])
        return false;

      return IsMonoIncreasing(arr, index + 1);
    }

    static void first()
    {
      double[] arr = new double[9];

      Console.WriteLine("Въведете 9 числа за проверка(-99.99 <= n <= 99.99):");

      for (int i = 0; i < 9; i++)
      {
        Console.Write($"{i}. елемент: ");
        double num = double.Parse(Console.ReadLine());

        while (num < -99.99 || num > 99.99)
        {
          Console.Write($"Числото трябва да е от интервала [-99.99..99.99]!\n{i}. елемент: ");
          num = double.Parse(Console.ReadLine());
        }

        arr[i] = num;
      }

      Console.WriteLine(IsMonoIncreasing(arr, 0) ? "Редицата Е монотонно нарастваща." : "Редицата НЕ Е монотонно нарастваща.");
    }

    //2. Задача
    static bool IsPrime(int n)
    {
      if (n < 2)
        return false;

      for (int i = 2; i * i <= n; i++)
        if (n % i == 0)
          return false;

      return true;
    }

    static int ClosestPrime(int n)
    {
      int closestPrime = n + 1;

      while (!IsPrime(closestPrime))
        closestPrime++;

      return closestPrime;
    }

    static void second()
    {
      int n;

      do
      {
        Console.Write("Въведете N(10 <= N <= 100010): ");
        n = int.Parse(Console.ReadLine());
      } while (10 > n || n > 100010);

      Console.WriteLine($"Следващо просто: {ClosestPrime(n)}");

    }

    //3. Задача
    static int SumOfDigits(int n)
    {
      if (n == 0)
        return n;

      return (n % 10) + SumOfDigits(n / 10);
    }

    static void third()
    {
      int n;

      do
      {
        Console.Write("Въведете N(10 <= N <= 10010): ");
        n = int.Parse(Console.ReadLine());
      } while (10 > n || n > 10010);

      Console.WriteLine($"Сумата на цифрите: {SumOfDigits(n)}");
    }

    static void Main(string[] args)
    {
      first();
      Console.WriteLine();

      second();
      Console.WriteLine();

      third();
    }
  }
}
