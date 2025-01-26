using DesignPatterns.FactoryPattern.Pizzas;

namespace DesignPatterns.FactoryPattern
{
    public class ChicagioPizzaStore: PizzaStore
    {
      protected override Pizza CreatePizza(string type)
      {
        if(type == "Cheeze")
        {
          return new ChicagoStyleCheesePizza();
        }
        else
        {
          return new ChicagoStylePepperoniPizza();
        }
      }
    }
}
