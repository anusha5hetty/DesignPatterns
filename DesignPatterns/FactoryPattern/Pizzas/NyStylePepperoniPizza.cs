namespace DesignPatterns.FactoryPattern.Pizzas
{
  public class NyStylePepperoniPizza : Pizza
  {
    public NyStylePepperoniPizza()
    {
      Name = "Ny Style Pepperoni Pizza";
      Dough = "Thin Crust Dough";
      Sauce = "Marinara Sauce";

      Toppings.Add("Grated Pepperoni Cheeze");
      Toppings.Add("Grated Cheeze");
    }
  }
}
