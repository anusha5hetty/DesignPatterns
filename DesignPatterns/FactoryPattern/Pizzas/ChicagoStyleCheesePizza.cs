namespace DesignPatterns.FactoryPattern.Pizzas
{
  public class ChicagoStyleCheesePizza : Pizza
  {
    public ChicagoStyleCheesePizza()
    {
      Name = "Chicago Style Deep Dish Cheeze Pizza";
      Dough = "Extra Thin Crust Dough";
      Sauce = "Plum Tomato Sauce";

      Toppings.Add("Shredded Mozerella Cheeze");
    }
  }
}
