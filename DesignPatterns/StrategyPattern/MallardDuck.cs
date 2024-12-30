using DesignPatterns.StrategyPattern.FlyBehavior;
using DesignPatterns.StrategyPattern.QuackBehavior;

namespace DesignPatterns.StrategyPattern
{
  public class MallardDuck: Duck
  {
    public MallardDuck()
    {
      quackBehavior = new MuteQuack();
      flyBehavior = new FlyNoWay();
    }
  }
}
