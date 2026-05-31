using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
  internal class Time
  {
    private int hour { get; set; }
    private int minute { get; set; }
    private int second { get; set; }

    public Time()
    {
      hour = minute = second = 0;
    }

    public Time(int hour, int minute, int second)
    {
      this.hour = hour;
      this.minute = minute;
      this.second = second;
    }

    public override string ToString()
    {
      return $"{hour.ToString("D2")}:{minute.ToString("D2")}:{second.ToString("D2")}";
    }
  }
}
