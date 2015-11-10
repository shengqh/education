using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public static class Utils
  {
    public static int GetIndex(Random rand, int maxValue)
    {
      var result = rand.Next(maxValue + 1);
      if (result == maxValue + 1)
      {
        result = maxValue;
      }
      return result;
    }
  }
}
