using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class BankAccount
  {
    private int id { get; set; }
    private string ownerName { get; set; }
    private double balance { get; set; }
    public double Balance
    {
      get { return balance; }
    }

    public BankAccount(string ownerName)
    {
      Random r = new Random();
      id = r.Next(1000000,9999999);
      this.ownerName = ownerName;
      balance = 0;
    }

    public void Add(double sum)
    {
      this.balance += sum;
      Console.WriteLine($"Added {sum} to the balance!");
    }
    public void Pull(double sum)
    {
      this.balance -= sum;
      Console.WriteLine($"Pulled {sum} from the balance!");
    }

    public override string ToString()
    {
      return $"Id: {id}\nOwner name: {ownerName}\nBalance: {balance}";
    }
  }
}
