namespace DesignPatterns.StrategyPattern.QuackBehavior
{
  public class Quack: QuackBehavior
  {
    public override void Quacking()
    {
      Console.WriteLine("Quack Quack");
    }
  }
}
