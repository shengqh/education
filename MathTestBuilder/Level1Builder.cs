using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class Level1Builder : AddtionSubtractionBuilder
  {
    public Level1Builder() : base(new[] { 0, 1, 2, 3, 4, 5 }, 0) { }
  }
}
