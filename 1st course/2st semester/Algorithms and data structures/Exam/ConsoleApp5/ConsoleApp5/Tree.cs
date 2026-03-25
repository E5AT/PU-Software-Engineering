using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  internal class Tree<T>
  {
    TreeNode<T> root;

    public Tree(T root)
    {
      this.root = new TreeNode<T>(root);
    }

    public Tree(T root, params Tree<T>[] subtrees) : this(root)
    {
      foreach (Tree<T> tree in subtrees)
      {
        this.root.childs.Add(tree.root);
      }
    }

    public void DFS()
    {
      Stack<TreeNode<T>> stack = new Stack<TreeNode<T>>();
      
      stack.Push(root);

      while (stack.Count > 0) {
        var current = stack.Pop();
        Console.WriteLine(current.value);

        foreach (var item in current.childs)
          stack.Push(item);
      }
    }

    public void BFS()
    {
      Queue<TreeNode<T>> queue = new Queue<TreeNode<T>>();

      queue.Enqueue(root);

      while (queue.Count > 0)
      {
        var current = queue.Dequeue();
        Console.WriteLine(current.value);

        foreach (var item in current.childs)
          queue.Enqueue(item);
      }
    }
  }
}
