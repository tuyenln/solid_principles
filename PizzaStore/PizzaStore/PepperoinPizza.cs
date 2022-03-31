using System;
namespace PizzaStore
{
    public class PepperoinPizza : Pizza
    {
        public PepperoinPizza()
        {
            name = "Peperoini Pizza";
            dough = "Thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");
        }
    }
}
