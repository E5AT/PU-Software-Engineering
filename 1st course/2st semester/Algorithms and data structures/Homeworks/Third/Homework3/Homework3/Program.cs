using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Homework3
{
  internal class Program
  {
    //1. Задача
    static List<object> Intersection(List<object> arr1, List<object> arr2)
    {
      List<object> inter = new List<object>();

      foreach (object el in arr1)
        if (arr2.Contains(el))
          inter.Add(el);

      return inter.Distinct().ToList();
    }

    static List<object> Union(List<object> x, List<object> y)
    {
      List<object> union = new List<object>();

      foreach (object el in x)
        if (!union.Contains(el))
          union.Add(el);

      foreach (object el in y)
        if (!union.Contains(el))
          union.Add(el);

      return union;
    }

    //2. Задача
    static List<int> LongestEqualSeq(List<int> arr)
    {
      if (arr.Count == 0) return new List<int>();

      int bestStart, bestLength, currStart, currLength;
      bestStart = currStart = 0;
      bestLength = currLength = 1;

      for (int i = 1; i < arr.Count; i++)
        if (arr[i] == arr[i - 1])
        {
          currLength++;
          if (currLength > bestLength)
          {
            bestLength = currLength;
            bestStart = currStart;
          }
        }
        else
        {
          currStart = i;
          currLength = 1;
        }

      return arr.GetRange(bestStart, bestLength);
    }

    //3. Задача
    static List<int> RemoveNegs(List<int> arr)
    {
      return arr.Where(x => x >= 0).ToList();
    }

    //4. Задача
    class Node<T>
    {
      public T value;
      public Node<T> prev, next;
      public Node(T value)
      {
        this.value = value;
      }
    }

    class DoubleLinkedList<T>
    {
      private Node<T> head, tail;
      private int count;

      public void Add(T value)
      {
        Node<T> node = new Node<T>(value);

        if (tail == null)
          head = tail = node;
        else
        {
          node.prev = tail;
          tail.next = tail = node;
        }
        count++;
      }

      public void Remove(T value)
      {
        Node<T> curr = head;

        while (curr != null)
        {
          if (curr.value.Equals(value))
          {
            if (curr.prev != null)
              curr.prev.next = curr.next;
            else
              head = curr.next;

            if (curr.next != null)
              curr.next.prev = curr.prev;
            else tail = curr.prev;

            count--;
            return;
          }
          curr = curr.next;
        }
      }

      public int Search(T value)
      {
        Node<T> curr = head;
        int index = 0;

        while (curr != null)
        {
          if (curr.value.Equals(value))
            return index;

          index++;
          curr = curr.next;
        }

        return -1;
      }

      public void Add(T value, int index)
      {
        if (index < 0 || index > count)
          return;

        if (index == count)
        {
          Add(value);
          return;
        }

        Node<T> curr = head;

        for (int i = 0; i < index; i++)
          curr = curr.next;

        Node<T> node = new Node<T>(value)
        {
          next = curr,
          prev = curr.prev
        };

        if (curr.prev != null)
          curr.prev.next = node;
        else head = node;

        curr.prev = node;
        count++;

      }

      public T At(int index)
      {
        if (index < 0 || index >= count) return default(T);

        Node<T> curr = head;
        for (int i = 0; i < index; i++)
          curr = curr.next;

        return curr.value;
      }

      public T[] ToArray()
      {
        Node<T> curr = head;
        T[] arr = new T[count];

        for (int i = 0; i < count; i++)
        {
          arr[i] = curr.value;
          curr = curr.next;
        }

        return arr;
      }
    }

    //5. Задача
    static int MaxNum(int[] arr, int num)
    {
      Array.Sort(arr);

      foreach (int el in arr)
        if (el == num)
          num *= 2;

      return num;
    }

    //6. Задача
    static int CountDifferentRegions(char[,] arr)
    {
      int
        rows = arr.GetLength(0),
        cols = arr.GetLength(1),
        count = 0;

      bool[,] visited = new bool[rows, cols];

      int[]
        dr = { -1, 1, 0, 0 },
        dc = { 0, 0, -1, 1 };

      for (int i = 0; i < rows; i++)
        for (int j = 0; j < cols; j++)
        {
          if (!visited[i, j])
          {
            count++;
            char target = arr[i, j];

            Queue<(int, int)> queue = new Queue<(int, int)>();
            queue.Enqueue((i, j));
            visited[i, j] = true;

            while (queue.Count > 0)
            {
              var (cr, cc) = queue.Dequeue();

              for (int d = 0; d < 4; d++)
              {
                int
                  nr = cr + dr[d],
                  nc = cc + dc[d];

                if (nr >= 0 && nr < rows &&
                   nc >= 0 && nc < cols &&
                   !visited[nr, nc] &&
                   arr[nr, nc] == target)
                {
                  visited[nr, nc] = true;
                  queue.Enqueue((nr, nc));
                }
              }
            }
          }
        }
      return count;
    }

    //7. Задача
    class TreeNode
    {
      public int value;
      public TreeNode left, right;
      public TreeNode(int value)
      {
        this.value = value;
      }
    }

    static TreeNode TreeParse(string[] s)
    {
      if (s.Length == 0 || s[0] == "null") return null;

      TreeNode root = new TreeNode(int.Parse(s[0]));
      Queue<TreeNode> queue = new Queue<TreeNode>();
      queue.Enqueue(root);
      int i = 1;

      while (queue.Count > 0 && i < s.Length)
      {
        TreeNode curr = queue.Dequeue();

        if (i < s.Length)
        {
          if (s[i] != "null")
          {
            curr.left = new TreeNode(int.Parse(s[i]));
            queue.Enqueue(curr.left);
          }
          i++;
        }

        if (i < s.Length)
        {
          if (s[i] != "null")
          {
            curr.right = new TreeNode(int.Parse(s[i]));
            queue.Enqueue(curr.right);
          }
          i++;
        }
      }
      return root;
    }

    static bool RecursiveBSTChecker(TreeNode node, int? min, int? max)
    {
      if (node == null) return true;

      if ((min != null && node.value <= min) || (max != null && node.value >= max))
        return false;

      return RecursiveBSTChecker(node.left, min, node.value) && RecursiveBSTChecker(node.right, node.value, max);

    }

    static bool isValidBinarySearchTree(string s)
    {
      if (string.IsNullOrEmpty(s) || s == "null") return true;

      return RecursiveBSTChecker(TreeParse(s.Split(',')), null, null);
    }

    static void Main()
    {
    }
  }
}