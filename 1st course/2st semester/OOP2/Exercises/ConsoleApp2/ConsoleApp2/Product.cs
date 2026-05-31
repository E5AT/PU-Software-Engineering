using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class Product
  {
    private string name { get; set; }
    public double price { get; set; }
    public int quantity { get; set; }

    public Product(string name, double price, int quantity)
    {
      this.name = name;
      this.price = price;
      this.quantity = quantity;
    }


    public override string ToString()
    {
      return $"Name: {name}, Price: {price}, Quantity: {quantity}";
    }
  }
}
