using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Book
  {
    private string title { get; set; }
    private string author { get; set; }
    private int pages { get; set; }
    private double price { get; set; }

    public Book()
    {
      title = author = String.Empty;
      price = pages = 0;
    }

    public Book(string title, string author, int pages, double price)
    {
      this.title = title;
      this.author = author;
      this.pages = pages;
      this.price = price;
    }

    public override string ToString()
    {
      return $"Заглавие: {title}, Автор: {author}, Цена: {price}";
    }
  }
}
