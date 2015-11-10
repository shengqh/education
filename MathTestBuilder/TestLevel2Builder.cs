using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class TestLevel2Builder : ITestBuilder
  {
    public List<TestItem> Build()
    {
      var digits = new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
      var signs = new[] { '-', '+' };
      var seed = DateTime.Now.Millisecond;
      var rand = new Random(seed);

      Dictionary<char, HashSet<TestItem>> data = new Dictionary<char, HashSet<TestItem>>();
      data[signs[0]] = new HashSet<TestItem>();
      data[signs[1]] = new HashSet<TestItem>();
      var maxvalue = digits.Max();
      var minvalue = 6;

      foreach (var digit1 in digits)
      {
        foreach (var digit2 in digits)
        {
          var sum = digit1 + digit2;
          if (sum <= maxvalue && sum >= minvalue)
          {
            data['+'].Add(new TestItem(digit1, '+', digit2));
            data['+'].Add(new TestItem(digit2, '+', digit1));
            data['-'].Add(new TestItem(sum, '-', digit1));
            data['-'].Add(new TestItem(sum, '-', digit2));
          }
        }
      }

      return (from v in data.Values
              from vv in v
              select vv).ToList();
    }
  }
}
