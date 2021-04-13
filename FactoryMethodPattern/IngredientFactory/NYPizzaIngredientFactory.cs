using FactoryMethodPattern.AbstractIngredients;
using FactoryMethodPattern.RegionalIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.IngredientFactory
{
    public class NYPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new ReggianoCheese();
        }

        public Clams CreateClams()
        {
            return new FreshClams();
        }

        public Dough CreateDough()
        {
            return new ThinCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new MarinaraSauce();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[] { new Garlic(), new Onion(), new Mushroom(), new RedPepper() };
        }
    }
}
