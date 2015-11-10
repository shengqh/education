using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class TestLevel1Builder : AddtionSubtractionBuilder
  {
    public TestLevel1Builder() : base(new[] { 0, 1, 2, 3, 4, 5 }, 0) { }
  }
}
