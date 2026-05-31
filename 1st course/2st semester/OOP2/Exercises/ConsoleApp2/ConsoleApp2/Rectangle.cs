using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
  internal class Rectangle
  {
    private double width { get; set; }
    private double height { get; set; }

    public Rectangle()
    {
      width = height = 0;
    }
    public Rectangle(double width, double height)
    {
      this.width = width;
      this.height = height;
    }
    public double Area()
    {
      return width * height;
    }
    public double Perimeter()
    {
      return (2 * width) + (2 * height);
    }
    public override string ToString()
    {
      return $"Width: {width}\nHeight: {height}";
    }
  }
}
