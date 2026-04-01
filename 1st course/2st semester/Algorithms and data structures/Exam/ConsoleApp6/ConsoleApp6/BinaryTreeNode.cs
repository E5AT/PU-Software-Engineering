using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
  internal class BinaryTreeNode<T> : IComparable<BinaryTreeNode<T>> where T : IComparable<T>
  {
    public T Value { get; set; }
    public BinaryTreeNode<T> Parent { get; set; }
    public BinaryTreeNode<T> Left { get; set; }
    public BinaryTreeNode<T> Right { get; set; }

    public BinaryTreeNode(T value)
    {
      Value = value;
    }

    public BinaryTreeNode(T value, BinaryTreeNode<T> left, BinaryTreeNode<T> right)
    {
      Value = value;
      //Parent = parent;
      Left = left;
      Right = right;
    }

    public int CompareTo(BinaryTreeNode<T> other)
    {
      return Value.CompareTo(other.Value);
    }
  }
}
