namespace DesignPatterns.StrategyPattern.QuackBehavior
{
  public class Squeak: QuackBehavior
  {
    public override void Quacking()
    {
      Console.WriteLine("Squeak Squeak");
    }
  }
}
