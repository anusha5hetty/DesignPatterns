using DesignPatterns.StrategyPattern.FlyBehavior;
using DesignPatterns.StrategyPattern.QuackBehavior;

namespace DesignPatterns.StrategyPattern
{
  public class LivingDuck: Duck
  {
    public LivingDuck()
    {
      quackBehavior = new Quack();
      flyBehavior = new FlyWithWings();
    }
  }
}
