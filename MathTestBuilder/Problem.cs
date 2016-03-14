using System;

namespace MathTestBuilder
{
  public class Problem : IEquatable<Problem>
  {
    public int LeftNumber { get; set; }
    public string Sign { get; set; }
    public int RightNumber { get; set; }

    public Problem(int leftNumber, string sign, int rightNumber)
    {
      this.LeftNumber = leftNumber;
      this.Sign = sign;
      this.RightNumber = rightNumber;
    }

    public bool Equals(Problem other)
    {
      if (other == null)
      {
        return false;
      }

      return (LeftNumber == other.LeftNumber) && (Sign.Equals(other.Sign)) && (RightNumber == other.RightNumber);
    }

    public override bool Equals(object obj)
    {
      if (!(obj is Problem))
      {
        return false;
      }

      return Equals(obj as Problem);
    }

    public override int GetHashCode()
    {
      return LeftNumber ^ Sign.GetHashCode() ^ RightNumber;
    }
  }
}
