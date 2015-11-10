using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class AddtionSubtractionBuilder : IBuilder
  {
    private int[] digits;
    private int minvalue;
    private Random rand;

    public AddtionSubtractionBuilder(int[] digits, int minvalue)
    {
      this.digits = digits;
      this.minvalue = minvalue;
      this.rand = new Random(DateTime.Now.Millisecond);
    }

    public List<Problem> Build()
    {
      var signs = new[] { '-', '+' };

      Dictionary<char, HashSet<Problem>> data = new Dictionary<char, HashSet<Problem>>();
      data[signs[0]] = new HashSet<Problem>();
      data[signs[1]] = new HashSet<Problem>();
      var maxvalue = digits.Max();

      foreach (var digit1 in digits)
      {
        foreach (var digit2 in digits)
        {
          var sum = digit1 + digit2;
          if (sum <= maxvalue && sum >= minvalue)
          {
            data['+'].Add(new Problem(digit1, '+', digit2));
            data['+'].Add(new Problem(digit2, '+', digit1));
            data['-'].Add(new Problem(sum, '-', digit1));
            data['-'].Add(new Problem(sum, '-', digit2));
          }
        }
      }

      return (from v in data.Values
              from vv in v
              select vv).ToList();
    }
  }
}
