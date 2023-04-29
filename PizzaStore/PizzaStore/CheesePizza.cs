﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public class CheesePizza: Pizza
    {
        public CheesePizza() {
            name = "The best cheese pizza";
            dough = "Very thin dough";
            sauce = "Very spicy sauce";
            toppings.Add("Black olives");
            toppings.Add("Cheese");
        }

        public override void Box()
        {
            Console.WriteLine("Boxing birthday present");
        }
    }
}
