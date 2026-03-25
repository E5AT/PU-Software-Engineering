using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  internal class TreeNode<T>
  {
    public T value;
    public List<TreeNode<T>> childs;

    public TreeNode(T value)
    {
      this.value = value;
      childs = new List<TreeNode<T>>();
    }

  }
}
