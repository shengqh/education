namespace MathTestBuilder
{
  public class Level2Builder : AddtionSubtractionBuilder
  {
    public Level2Builder() : base(new[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 6, 10) { }

    protected override bool Accept(Problem item)
    {
      if(item.Sign.Equals("+") && (item.LeftNumber == 0 || item.RightNumber == 0))
      {
        return false;
      }

      return true;
    }
  }
}
