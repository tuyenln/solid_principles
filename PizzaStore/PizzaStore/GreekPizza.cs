using System;
namespace PizzaStore
{
    public class GreekPizza : Pizza
    {
        public GreekPizza()
        {
            name = "Greek";
            dough = "Thin dough";
            sauce = "Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }
    }
}
