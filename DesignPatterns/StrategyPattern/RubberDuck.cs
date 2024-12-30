
using DesignPatterns.StrategyPattern.FlyBehavior;
using DesignPatterns.StrategyPattern.QuackBehavior;

namespace DesignPatterns.StrategyPattern
{
  public class RubberDuck: Duck
  {
    public RubberDuck()
    {
      quackBehavior = new Squeak();
      flyBehavior = new FlyNoWay();
    }
  }
}
