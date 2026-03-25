using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
  internal class BrowserHistory
  {
    Stack<string> back, forward;

    public BrowserHistory()
    {
      back = new Stack<string>();
      forward = new Stack<string>();
    }

    //Visit(url), Back(), Forward(), Current

    public string Visit(string url)
    {
      back.Push(url);
      forward = new Stack<string>();
      return Current();
    }

    public string Back()
    {
      if (back.Count == 1)
        return "On the lowest level!";

      forward.Push(back.Pop());
      return back.Peek();
    }

    public string Forward()
    {
      if (forward.Count == 0)
        return "On the highest level!";

      back.Push(forward.Pop());
      return back.Peek();
    }

    public string Current()
    {
      return back.Peek();
    }
  }
}
