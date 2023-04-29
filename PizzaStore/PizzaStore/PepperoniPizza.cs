using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class PepperoniPizza: Pizza
    {
        public PepperoniPizza() {
            name = "The best pepperoni pizza";
            dough = "Thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");

        }
    }
}
