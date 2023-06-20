namespace MethodChainingAndFluentInterfaces
{
    public class Pizza
    {
        public string Crust { get; set; }
        public string Sauce { get; set; }
        public List<string> Toppings { get; set; }

        public Pizza(string crust, string sauce, List<string> toppings)
        {
            Crust = crust;
            Sauce = sauce;
            Toppings = toppings;
        }
    }
}
