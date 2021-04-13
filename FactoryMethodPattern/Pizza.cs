using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class Pizza : IPizza
    {
        protected readonly IPizzaIngredientFactory _pizzaIngredientFactory;

        public string Name { get; set; }
        public Dough Dough { get; set; }
        public Sauce Sauce { get; set; }
        public Veggies[] Veggies { get; set; }
        public Cheese Cheese { get; set; }
        public Pepperoni Pepperoni { get; set; }
        public Clams Clams { get; set; }

        protected Pizza(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
            this.Veggies = new Veggies[] { };
        }

        public abstract string Prepare();
        public string Bake() => "Bake for 25 minutes at 350";
        public string Cut() => "Cutting the Pizza into diagonal slices";
        public string Box() => "Place pizza in official PizzaStore box";
        public string Label(string store)
        {
            this.Name = store + " " + this.Name;
            return "Label the Pizza according to the store";
        }

        public override string ToString()
        {
            StringBuilder pizzaDesc = new StringBuilder();
            pizzaDesc.Append("Pizza Description:\n");
            pizzaDesc.Append(string.Format("Name: {0}\nDough: {1}\nSauce: {2}\nCheese: {3}\nPepperoni: {4}\nClams: {5}\n",
                this.Name, this.Dough, this.Sauce, this.Cheese, this.Pepperoni, this.Clams));
            pizzaDesc.Append("Veggies:");
            foreach (Veggies veg in Veggies)
                pizzaDesc.Append(" " + veg);
            return pizzaDesc.ToString();
        }
    }
}
