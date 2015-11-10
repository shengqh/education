using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathTestBuilder
{
  public class TestItem : IEquatable<TestItem>
  {
    public int LeftNumber { get; set; }
    public char Sign { get; set; }
    public int RightNumber { get; set; }

    public TestItem(int leftNumber, char sign, int rightNumber)
    {
      this.LeftNumber = leftNumber;
      this.Sign = sign;
      this.RightNumber = rightNumber;
    }

    public bool Equals(TestItem other)
    {
      if (other == null)
      {
        return false;
      }

      return (LeftNumber == other.LeftNumber) && (Sign == other.Sign) && (RightNumber == other.RightNumber);
    }

    public override bool Equals(object obj)
    {
      if (!(obj is TestItem))
      {
        return false;
      }

      return Equals(obj as TestItem);
    }

    public override int GetHashCode()
    {
      return LeftNumber ^ Sign ^ RightNumber;
    }
  }
}
