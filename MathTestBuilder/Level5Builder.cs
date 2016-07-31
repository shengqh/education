using System.Collections.Generic;

namespace MathTestBuilder
{
  public class Level5Builder : AddtionSubtractionBuilder
  {
    private static int[] values;
    static Level5Builder()
    {
      var v = new List<int>();
      for(int i = 11;i < 99; i++)
      {
        v.Add(i);
      }
      values = v.ToArray();
    }
    public Level5Builder() : base(values, 22, 200) { }
  }
}
