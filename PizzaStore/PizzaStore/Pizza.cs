using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzaStore
{
    public abstract class Pizza
    {
        protected string name;
        protected string dough;
        protected string sauce;
        protected List<string> toppings = new List<string>();
        protected string type;

        public void Prepare()
        {
            Console.WriteLine("Preparing " + name);
            Console.WriteLine("Tossing dough...");
            Console.WriteLine("Adding sauce...");
            Console.WriteLine("Adding toppings...");
            toppings?.ForEach((topping) => Console.WriteLine("\t" + topping));
        }

        public void Bake()
        {
            Console.WriteLine("Baking " + name + " in 30 mins");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting " + name);
        }

        public virtual void Box()
        {
            Console.WriteLine("Boxing " + name);
        }
    }
}
