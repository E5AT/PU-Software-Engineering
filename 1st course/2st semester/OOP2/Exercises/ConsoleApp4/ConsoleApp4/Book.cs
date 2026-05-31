using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
  internal class Book
  {
    private string title;
    public string Title
    {
      get { return title; }
      set
      {
        if (string.IsNullOrWhiteSpace(value))
          throw new ArgumentException();

        title = value;
      }
    }

    private string author;
    public string Author
    {
      get { return author; }
      set
      {
        if (string.IsNullOrWhiteSpace(value))
          throw new ArgumentException();

        author = value;
      }
    }

    private string isbn;
    public string ISBN
    {
      get { return isbn; }
      set
      {
        //if (value.Length != 10 || value.Length != 13)
        //  throw new ArgumentException();

        //if (value.Length == 10)
        //{
        //  List<int> digits = value.ToCharArray().Select(x => x - '0').ToList();

        //  int index = 10, sum = 0 ;
        //  foreach(int digit in digits)
        //  {
        //    sum += digit * index;
        //    index--;
        //  }
        //  if(sum%11!=0)
        //    throw new ArgumentException();
        //  isbn = value;
        //}
        //else if(value.Length == 13)
        //{

        //}

        isbn = value;
      }
    }


    private int year;
    public int Year
    {
      get { return year; }
      set
      {
        if (value > DateTime.Today.Year)
          throw new ArgumentException();
        year = value;
      }
    }

    public override string ToString()
    {
      return $"{Title}, {Author}, {ISBN}, {Year}";
    }
  }
}
