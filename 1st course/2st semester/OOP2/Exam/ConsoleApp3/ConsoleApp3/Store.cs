using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
  internal class Store
  {
    Dictionary<Product, int> products;
    
    public Store()
    {
      products = new Dictionary<Product, int>();
    }

    public void AddProduct(Product product, int count)
    {
      if (product == null)
        throw new Exception("Product can't be null!");
      if (count < 0)
        throw new Exception("Count must be greater than 0!");

      products.Add(product, count);
    }

    

    public void RemoveProduct(string name)
    {
      Product productToRemove = Search(name);
      if(productToRemove != null)
        products.Remove(productToRemove);
      throw new Exception("Cannot find the product to remove!");
    }

    public void EditPrice(string name, int newPrice)
    {
     Product productToEdit = Search(name);
      if (productToEdit == null)
        throw new Exception("Cannot find the product to edit!");

      int quantity = products[productToEdit];
      products.Remove(productToEdit);
      productToEdit.Price = newPrice;
      products.Add(productToEdit, quantity);
    }


    public Product Search(string name)
    {
      return (Product)products.Where(x => x.Key.Name == name);
    }

    public void AddQuantity(string name, int quantity)
    {
      Product productToChangeQuantity = Search(name);

      if (productToChangeQuantity == null)
        throw new Exception("Cannot find product to update the quantity!");

      products[productToChangeQuantity] += quantity;
    }



    public void DecreaseQuantity(string name, int quantity)
    {
      Product productToDecreaseQuantity = Search(name);
      if (productToDecreaseQuantity == null)
        throw new Exception("Cannot find the product to decrease quantity!");

      products[productToDecreaseQuantity]-=quantity;
    }
  }
}
