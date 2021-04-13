using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public interface IPizzaIngredientFactory
    {
        Dough CreateDough();
        Sauce CreateSauce();
        Cheese CreateCheese();
        Veggies[] CreateVeggies();
        Pepperoni CreatePepperoni();
        Clams CreateClams();
    }
}
