namespace DesignPatterns.FactoryPattern.Pizzas
{
    public abstract class Pizza
    {
        protected string? Name;
        protected string? Dough;
        protected string? Sauce;
        protected List<string> Toppings = new();

        public void Prepare()
        {
            Console.WriteLine("Preparing " + Name);
            Console.WriteLine("Tossing Dough " + Dough);
            Console.WriteLine("Adding Sauce " + Sauce);
            Console.WriteLine("Adding Toppings");
            foreach (var item in Toppings)
            {
                Console.Write(item + ", ");
            }
        }

        public void Bake()
        {
            Console.WriteLine("Baking....");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting");
        }

        public void Box()
        {
            Console.WriteLine("Packaging The Pizza");
        }

        public string? GetName()
        {
            return Name;
        }
    }
}
