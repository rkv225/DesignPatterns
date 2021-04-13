using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Pizzas
{
    public class ClamPizza : Pizza
    {
        public ClamPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
            this.Name = "Clam Pizza";
        }
        public override string Prepare()
        {
            this.Dough = _pizzaIngredientFactory.CreateDough();
            this.Sauce = _pizzaIngredientFactory.CreateSauce();
            this.Cheese = _pizzaIngredientFactory.CreateCheese();
            this.Clams = _pizzaIngredientFactory.CreateClams();
            return "Preparing " + this.Name;
        }
    }
}
