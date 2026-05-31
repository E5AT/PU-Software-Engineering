using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ConsoleApp4
{
  internal class Library
  {
    List<Book> books = new List<Book>();

    public void AddBook(Book book)
    {
      if (book != null)
        books.Add(book);
    }

    public void RemoveBook(string ISBN)
    {
      books.Remove(books.Where(b => b.ISBN == ISBN).First());
    }

    public void DisplayBooks()
    {
      foreach(Book book in books)
        Console.WriteLine(book.ToString());
    }

    public void SerializeThing()
    {
      var json = JsonConvert.SerializeObject(books);
    }
  }
}
