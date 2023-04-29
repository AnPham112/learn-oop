using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Pizzas;
using PizzaStore.Pizzas.Base;

namespace PizzaStore.Pizzas.HCMPizzas
{
    public class HCMPepperoniPizza : Pizza
    {
        public HCMPepperoniPizza()
        {
            name = "The best pepperoni pizza";
            dough = "Thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");

        }
    }
}
