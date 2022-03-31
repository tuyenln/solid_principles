using System;
namespace PizzaStore
{
    public class CheesePizza : Pizza
    {
        public CheesePizza()
        {
            name = "My the best cheese pizza";
            dough = "Thin";
            sauce = "very spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Cheese");
        }
    }
}
