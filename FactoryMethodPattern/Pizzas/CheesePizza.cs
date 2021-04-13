using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Pizzas
{
    public class CheesePizza : Pizza
    {
        public CheesePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
            this.Name = "Cheese Pizza";
        }
        public override string Prepare()
        {
            this.Dough = _pizzaIngredientFactory.CreateDough();
            this.Sauce = _pizzaIngredientFactory.CreateSauce();
            this.Cheese = _pizzaIngredientFactory.CreateCheese();
            return "Preparing " + this.Name;
        }
    }
}
