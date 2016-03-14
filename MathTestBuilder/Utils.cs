using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public static class Utils
  {
    private static Random _random = new Random(DateTime.Now.Millisecond);

    public static int GetIndex(Random rand, int maxValue)
    {
      var result = rand.Next(maxValue + 1);
      if (result == maxValue + 1)
      {
        result = maxValue;
      }
      return result;
    }

    public static void Shuffle<T>(T[] array)
    {
      int n = array.Length;
      for (int i = 0; i < n; i++)
      {
        // NextDouble returns a random number between 0 and 1.
        // ... It is equivalent to Math.random() in Java.
        int r = i + (int)(_random.NextDouble() * (n - i));
        T t = array[r];
        array[r] = array[i];
        array[i] = t;
      }
    }
  }
}
