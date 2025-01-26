namespace DesignPatterns.FactoryPattern.Pizzas
{
  public class ChicagoStylePepperoniPizza : Pizza
  {
    public ChicagoStylePepperoniPizza()
    {
      Name = "Chicago Style Deep Dish Pepperoni Pizza";
      Dough = "Extra Thin Crust Dough";
      Sauce = "Plum Tomato Sauce";

      Toppings.Add("Chicago Pepperoni");
    }
  }
}
