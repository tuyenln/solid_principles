using System;
namespace PizzaStore
{
    public class PizzaStore
    {
        public void OrderPizza(String type)
        {
            Pizza pizza;

            switch(type)
            {
                case "cheese":
                    pizza = new CheesePizza();
                    break;
                case "greek":
                    pizza = new GreekPizza();
                    break;
                case "peperoin":
                    pizza = new PepperoinPizza();
                    break;
                default:
                    Console.WriteLine("We do not have this type " + type);
                    return;
            }
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
        }
    }
}
