using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  internal class Product
  {
    private string name;
    public string Name
    {
      get { return name; }
      set
      {
        if (value.Length >= 3)
          name = value;
        else
          throw new Exception("Name must be atleast 3 symbols long!");
      }
    }

    private double price;
    public double Price
    {
      get
      {
        return price;
      }
      set
      {
        if (value > 0)
          price = value;
        else
          throw new Exception("Price must be greater than 0!");
      }
    }

    private DateTime expirationDate;
    public DateTime ExpirationDate
    {
      get { return expirationDate; }
      set
      {
        if (value > DateTime.Today)
          expirationDate = value;
        else
          throw new Exception("Expiration date must be greater than todays date!");
      }
    }

    public Product(string name, double price, DateTime expirationDate)
    {
      this.name = name;
      this.price = price;
      this.expirationDate = expirationDate;
    }
  }
}
