using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Point
  {
    private int x { get; set; }
    private int y { get; set; }
    public Point()
    {
      x = y = 0;
    }
    public Point(int x, int y)
    {
      this.x = x;
      this.y = y;
    }
    public double DistanceBetween(Point p)
    {
      return Math.Sqrt(Math.Pow(p.x - x, 2) + Math.Pow(p.y - y, 2));
    }
  }
}
