using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class ProductStore
  {
    List<Product> products;
    public ProductStore()
    {
      products = new List<Product>();
    }
    public void Add(Product product)
    {
      products.Add(product);
    }
    public override string ToString()
    {
      return String.Join("\n", products.Select(x => x.ToString()));
    }
    public void ProductsWithPriceUnder20()
    {
      foreach(Product product in products)
        if(product.price<20)
          Console.WriteLine(product.ToString());
    }
    public double TotalSum()
    {
      return products.Select(x=> x.price * x.quantity).Sum();
    }
  }
}
