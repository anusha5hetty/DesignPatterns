using QBehavior = DesignPatterns.StrategyPattern.QuackBehavior;
using FBehavior = DesignPatterns.StrategyPattern.FlyBehavior;


namespace DesignPatterns.StrategyPattern
{
  public class Duck
  {
    protected QBehavior.QuackBehavior quackBehavior;
    protected FBehavior.FlyBehavior flyBehavior;

    public void Fly()
    {
      flyBehavior.Fly();
    }

    public void Quack()
    {
      quackBehavior.Quacking();
    }

    public void Swim()
    {
      Console.WriteLine("Swim Swim");
    }

  }
}
