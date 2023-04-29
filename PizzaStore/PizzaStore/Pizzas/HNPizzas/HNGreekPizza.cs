using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PizzaStore.Pizzas;

namespace PizzaStore.Pizzas.HCMPizzas
{
    public class HNGreekPizza : Base.Pizza
    {
        public HNGreekPizza()
        {
            name = "A good greek pizza";
            dough = "Thin dough";
            sauce = "Chilli sauce";
            toppings.Add("Tomato");
            toppings.Add("Potato");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing for Greek pizza");
        }
    }
}
