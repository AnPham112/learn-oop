using System;
using System.Collections.Generic;
using PizzaStore.Store;

namespace PizzaStore
{
    class Program
    {
        static void Main(string[] args)
        {
            var hnPizzaStore  = new HNPizzaStore();
            hnPizzaStore.OrderPizza("cheese");

            var hcmPizzaStore = new HCMPizzaStore();
            hcmPizzaStore.OrderPizza("cheese");

        }
    }
}