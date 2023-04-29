using System;
using PizzaStore.Pizzas.Base;
using PizzaStore.Pizzas.HCMPizzas;

namespace PizzaStore.Store
{
    public class HNPizzaStore : Base.PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch (type)
            {
                case "cheese":
                    return new HNCheesePizza();
                case "greek":
                    return new HNGreekPizza();
                case "pepperoni":
                    return new HNPepperoniPizza();
                default:
                    return null;
            }
        }
    }
}
