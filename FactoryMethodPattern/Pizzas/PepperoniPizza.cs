using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Pizzas
{
    public class PepperoniPizza : Pizza
    {
        public PepperoniPizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
            this.Name = "Pepperoni Pizza";
        }
        public override string Prepare()
        {
            this.Dough = _pizzaIngredientFactory.CreateDough();
            this.Sauce = _pizzaIngredientFactory.CreateSauce();
            this.Cheese = _pizzaIngredientFactory.CreateCheese();
            this.Pepperoni = _pizzaIngredientFactory.CreatePepperoni();
            return "Preparing " + this.Name;
        }
    }
}
