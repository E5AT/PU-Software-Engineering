using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp4
{
  internal class Program
  {
    static void Main(string[] args)
    {
      StreamReader r = new StreamReader("test.txt");
      string text = r.ReadToEnd();
      string wordToSearch = Console.ReadLine();
      Console.WriteLine(text.Contains(wordToSearch)?"Yes, we can find this word in our file":"Nope, this word is not in our file...");
    }
  }
}
