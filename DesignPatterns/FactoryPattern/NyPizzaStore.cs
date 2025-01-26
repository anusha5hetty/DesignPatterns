using DesignPatterns.FactoryPattern.Pizzas;

namespace DesignPatterns.FactoryPattern
{
    public class NyPizzaStore: PizzaStore
    {
      protected override Pizza CreatePizza(string type)
      {
        if(type == "Cheeze")
        {
          return new NyStyleCheesePizza();
        }
        else
        {
          return new NyStylePepperoniPizza();
        }
      }
    }
}
