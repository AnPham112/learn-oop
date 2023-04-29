using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Pizzas;

namespace PizzaStore.Pizzas.HCMPizzas
{
    public class HNPepperoniPizza : Base.Pizza
    {
        public HNPepperoniPizza()
        {
            name = "The best pepperoni pizza";
            dough = "Thick dough";
            sauce = "Sweet sauce";
            toppings.Add("Tomato");

        }
    }
}
