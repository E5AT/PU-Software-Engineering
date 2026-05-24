using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//тест+задачи
//всякакви задачки
//класичеко, двоично, за търсене, баланисрано двоично дърво
namespace ConsoleApp6
{
  internal class Program
  {
    static void Main(string[] args)
    {
      BinaryTree<int> binaryTree = new BinaryTree<int>(4, new BinaryTree<int>(2, new BinaryTree<int>(1), new BinaryTree<int>(3)), new BinaryTree<int>(6, new BinaryTree<int>(5), new BinaryTree<int>(7)));

      Console.WriteLine(binaryTree.BinaryTreeSearch(5).Value);

      Console.WriteLine(binaryTree.BinaryTreeSearch(0));

      //Console.WriteLine(binaryTree.AddNewNode(0));

      Console.WriteLine(binaryTree.BinaryTreeSearch(0).Value);
      
    }
  }
}
