using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.StrategyPattern.FlyBehavior
{
  internal class FlyNoWay: FlyBehavior
  {
    public override void Fly()
    {
      Console.WriteLine("No Wings, No Fly!! ");
    }
  }
}
