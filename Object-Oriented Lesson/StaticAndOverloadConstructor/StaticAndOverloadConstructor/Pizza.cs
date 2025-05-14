using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticAndOverloadConstructor
{
    public class Pizza
    {
        String? bread;
        String? sauce;
        String? cheese;
        String? topping;
        static int numOfPizza;

        public Pizza()
        {
            numOfPizza++;
        }
        public Pizza(string bread)
        {
            this.bread = bread;
            numOfPizza++;
        }

        public Pizza(string bread, string sauce)
        {
            this.bread = bread;
            this.sauce = sauce;
            numOfPizza++;
        }

        public Pizza(string bread, string sauce,string cheese)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            numOfPizza++;
        }

        public Pizza(string bread, string sauce, string cheese, string topping)
        {
            this.bread = bread;
            this.sauce = sauce;
            this.cheese = cheese;
            this.topping = topping;
            numOfPizza++;
        }

        public string getPizza()
        {
            if (bread == null && sauce == null && cheese == null && topping == null)
            {
                return "You did not order any pizza DUMMY!!";
            }

            if (bread != null && sauce == null && cheese == null && topping == null)
            {
                return $"You only ordered a {bread} without sauce, cheese, and toppings on it DUMMY!!";
            }

            if (bread != null && sauce != null && cheese == null && topping == null)
            {
                return $"You only ordered a {bread} and {sauce} without cheese and toppings on it DUMMY!!";
            }

            if (bread != null && sauce != null && cheese != null && topping == null)
            {
                return $"You only ordered a {bread}, {sauce}, and {cheese} without toppings on it DUMMY!!";
            }

            if (bread != null && sauce != null && cheese != null && topping != null)
            {
                return $"The {bread} with {sauce}, {cheese}, and {topping} pizza is ready";
            }

            return "Your pizza is weird!";
        }


        public static int getNumPizza()
        {
            return numOfPizza;
        }


    }
}
