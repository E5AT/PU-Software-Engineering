using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Program
  {
    static bool IsLeap(int year)
    {
      if (year % 4 == 0)
      {
        if (year % 100 == 0)
        {
          if (year % 400 == 0) return true;
          return false;
        }
        return true;
      }
      return false;
    }

    static void PrimesLowerThanOrEqualTo(int num)
    {
      for(int i = 2; i < num; i++)
      {
        bool isPrime = true;
        for (int j = 2; j * j <= num; j++)
          if (i % j == 0)
          {
            isPrime = false;
            break;
          }
        Console.WriteLine(isPrime?i.ToString():"");
      }
    }

    static int? CountOfDays(int month, int year)
    {
      switch (month)
      {
        case 1: case 3: case 5: case 7: case 8: case 10: case 12:
          return 31;

        case 4: case 6: case 9: case 11:
          return 30;

        case 2:
          return IsLeap(year) ? 29 : 28;

        default:
          return null;
      }
    }

    static bool AreTheseArraysTheSame(object[] arr1, object[] arr2)
    {
      if (arr1.Length != arr2.Length) return false;

      for (int i = 0; i < arr1.Length; i++)
        if (arr1[i] != arr2[i]) return false;

      return true;
    }

    static void Fifth()
    {
      int[] arr = new int[20];

      for (int i = 0; i < 20; i++)
        arr[i] = i * 2;

      List<int> elsBiggerThan20 = arr.Where(x => x > 20).ToList();

      Console.WriteLine($"Елементи по-големи от 20: {string.Join(", ", elsBiggerThan20)}");
      Console.WriteLine($"Сума: {elsBiggerThan20.Sum()}");
    }
    static void Main(string[] args)
    {
      ////First
      //int year;
      //do
      //{
      //  Console.Write("Year: "); year = int.Parse(Console.ReadLine());
      //} while (year < 0);

      //Console.WriteLine($"{year} {(IsLeap(year)?"":"не")} е високосна");

      ////Second
      //int num;
      //do
      //{
      //  Console.Write("Num: "); num = int.Parse(Console.ReadLine());
      //} while (num < 0);
      //PrimesLowerThanOrEqualTo(num);

      ////Third
      //int month;
      //Console.Write("Month num: "); month = int.Parse(Console.ReadLine());
      //Console.Write("Year: "); year = int.Parse(Console.ReadLine());
      //int? result = CountOfDays(month, year);
      //Console.WriteLine($"Count of days: {(result==null?"unvalid num of month":result.ToString())}");

      ////Fourth

      ////Fifth
      //Fifth();

      Point p1 = new Point(-2, -2);
      Point p2 = new Point(2, 6);
      Console.WriteLine(p1.DistanceBetween(p2));
    }
  }
}
