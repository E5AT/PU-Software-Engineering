using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
  internal class BinaryTree<T> : IComparable<BinaryTree<T>> where T : IComparable<T>
  {
    private BinaryTreeNode<T> Root;

    public BinaryTree(T value)
    {
      Root = new BinaryTreeNode<T>(value);
    }

    public BinaryTree(T value, BinaryTree<T> leftTree, BinaryTree<T> rightTree)
      : this(value)
    {
      BinaryTreeNode<T> leftChild = leftTree != null ? leftTree.Root : null;
      BinaryTreeNode<T> rightChild = rightTree != null ? rightTree.Root : null;

      Root = new BinaryTreeNode<T>(value, leftChild, rightChild);
      leftChild.Parent = Root;
      rightChild.Parent = Root;
    }


    public int CompareTo(BinaryTree<T> other)
    {
      return Root.Value.CompareTo(other.Root.Value);
    }

    public BinaryTreeNode<T> BinaryTreeSearch(T value)
    {
      BinaryTreeNode<T> current = Root;

      while (current != null)
      {
        int result = value.CompareTo(current.Value);

        if (result == 0)
          return current;

        else if (result < 0)
          current = current.Left;

        else
          current = current.Right;
      }

      return current;
    }

    public void AddNewNode(T value)
    {
      BinaryTreeNode<T> current = Root;

      while (current != null)
      {
        int result = value.CompareTo(current.Value);

        if (result == 0)
          break;

        if (result > 0)
        {
          {
            if (current.Right == null)
            {
              current.Right = new BinaryTreeNode<T>(value);
              break;
            }
            current = current.Right;
          }
        }
        else
        {
          if (current.Left == null)
          {
            current.Left = new BinaryTreeNode<T>(value);
            break;
          }
          current = current.Left;
        }
      }
    }


    //указания
    //3 случая:
    //[x]без наследник
    //[x]един наследник
    //[]повече от два..


    public void DeleteNode(T value)
    {
      BinaryTreeNode<T> NodeToDelete = BinaryTreeSearch(value);

      //без наследник
      if (NodeToDelete.Right==null && NodeToDelete.Left == null)
      {
        if (NodeToDelete.Value.CompareTo(Root.Value)==0)
          Root = null;

        else if (NodeToDelete.Parent.Left.Value.CompareTo(value) == 0)
          NodeToDelete.Parent.Left = null;

        else
          NodeToDelete.Parent.Right = null;
       }

      //един наследник
      else if ((NodeToDelete.Left == null && NodeToDelete.Right != null) || (NodeToDelete.Left != null && NodeToDelete.Right == null))
      {
        BinaryTreeNode<T> onlyChild = NodeToDelete.Left == null ? NodeToDelete.Right : NodeToDelete.Left;

        if(NodeToDelete.Value.CompareTo(Root.Value)==0)
          Root = onlyChild;

        else if(NodeToDelete.Parent.Left.Value.CompareTo(value) == 0)
          NodeToDelete.Parent.Left = onlyChild;

        else
          NodeToDelete.Parent.Right = onlyChild;
      }

      //повече от два
      else
      {

      }



    }
    
  }
}