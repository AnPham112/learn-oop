using System;
using PizzaStore.Pizzas.Base;
using PizzaStore.Pizzas.HCMPizzas;

namespace PizzaStore.Store
{
    public class HCMPizzaStore : Base.PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            switch(type)
            {
                case "cheese":
                    return new HCMCheesePizza();
                case "greek":
                    return new HCMGreekPizza();
                case "pepperoni":
                    return new HCMPepperoniPizza();
                default:
                    return null;
            } 

        }
    }
}
