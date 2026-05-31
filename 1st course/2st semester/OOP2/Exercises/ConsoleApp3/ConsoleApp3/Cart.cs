using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  internal class Cart
  {
    List<Product> cart;

    public Cart()
    {
      cart = new List<Product>();
    }

    public void AddProduct(Product product, Store store)
    {
      //if(store.Search(product.Name))
    }

    public void RemoveProduct(Product product)
    {
      cart.Remove(cart.Where(x => x == product).First());
    }

    public double Total()
    {
      return cart.Sum(x => x.Price);
    }
  }
}
