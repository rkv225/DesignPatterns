using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.Pizzas
{
    public class VeggiePizza : Pizza
    {
        public VeggiePizza(IPizzaIngredientFactory pizzaIngredientFactory) : base(pizzaIngredientFactory)
        {
            this.Name = "Veggie Pizza";
        }
        public override string Prepare()
        {
            this.Dough = _pizzaIngredientFactory.CreateDough();
            this.Sauce = _pizzaIngredientFactory.CreateSauce();
            this.Cheese = _pizzaIngredientFactory.CreateCheese();
            this.Veggies = _pizzaIngredientFactory.CreateVeggies();
            return "Preparing " + this.Name;
        }
    }
}
