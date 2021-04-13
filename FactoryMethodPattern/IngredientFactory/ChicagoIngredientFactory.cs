using FactoryMethodPattern.AbstractIngredients;
using FactoryMethodPattern.RegionalIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.IngredientFactory
{
    public class ChicagoIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            return new MozarellaCheese();
        }

        public Clams CreateClams()
        {
            return new FrozenClams();
        }

        public Dough CreateDough()
        {
            return new ThickCrustDough();
        }

        public Pepperoni CreatePepperoni()
        {
            return new SlicedPepperoni();
        }

        public Sauce CreateSauce()
        {
            return new PlumTomatoSauce();
        }

        public Veggies[] CreateVeggies()
        {
            return new Veggies[] { new BlackOlives(), new Spinach(), new EggPlant() };
        }
    }
}
