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
    private int maxvalue;
    private Random rand;

    public AddtionSubtractionBuilder(int[] digits, int minvalue, int maxvalue)
    {
      this.digits = digits;
      this.minvalue = minvalue;
      this.maxvalue = maxvalue;
      this.rand = new Random(DateTime.Now.Millisecond);
    }

    protected virtual bool Accept(Problem item)
    {
      return true;
    }

    protected void AddItemToSet(HashSet<Problem> set, Problem item)
    {
      if (Accept(item))
      {
        set.Add(item);
      }
    }

    public List<Problem> Build()
    {
      var data = new HashSet<Problem>();
      foreach (var digit1 in digits)
      {
        foreach (var digit2 in digits)
        {
          var sum = digit1 + digit2;
          if (sum <= maxvalue && sum >= minvalue)
          {
            AddItemToSet(data, new Problem(digit1, "+", digit2));
            AddItemToSet(data, new Problem(digit2, "+", digit1));
            AddItemToSet(data, new Problem(sum, "-", digit1));
            AddItemToSet(data, new Problem(sum, "-", digit2));
          }
        }
      }

      return data.ToList();
    }
  }
}
