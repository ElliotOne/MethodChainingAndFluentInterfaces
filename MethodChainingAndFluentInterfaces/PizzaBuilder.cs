namespace MethodChainingAndFluentInterfaces
{
    public class PizzaBuilder
    {
        private string _crust;
        private string _sauce;
        private List<string> _toppings;

        public PizzaBuilder WithCrust(string crustType)
        {
            _crust = crustType;
            return this;
        }

        public PizzaBuilder WithSauce(string sauceType)
        {
            _sauce = sauceType;
            return this;
        }

        public PizzaBuilder WithToppings(params string[] pizzaToppings)
        {
            _toppings = pizzaToppings.ToList();
            return this;
        }

        public Pizza Build()
        {
            return new Pizza(_crust, _sauce, _toppings);
        }
    }

}
