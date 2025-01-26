namespace DesignPatterns.FactoryPattern.Pizzas
{
  public class NyStyleCheesePizza: Pizza
  {
    public NyStyleCheesePizza()
    {
      Name = "Ny Style Cheeze Pizza";
      Dough = "Thin Crust Dough";
      Sauce = "Marinara Sauce";

      Toppings.Add("Grated Regiano Cheeze");
    }
  }
}
