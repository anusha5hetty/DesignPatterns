namespace DesignPatterns.StrategyPattern.QuackBehavior
{
  public class MuteQuack: QuackBehavior
  {
    public override void Quacking()
    {
      Console.WriteLine("Mummmmmmmm");
    }
  }
}
