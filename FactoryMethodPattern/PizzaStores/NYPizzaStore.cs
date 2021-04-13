using FactoryMethodPattern.IngredientFactory;
using FactoryMethodPattern.Pizzas;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.PizzaStores
{
    public class NYPizzaStore : PizzaStore
    {
        public NYPizzaStore() : base(new NYPizzaIngredientFactory())
        {
            this.StoreName = "NY";
        }
        protected override IPizza CreatePizza(PizzaMenu item)
        {
            Pizza pizza = null;
            switch (item)
            {
                case PizzaMenu.CheesePizza:
                    pizza = new CheesePizza(_pizzaIngredientFactory);
                    break;
                case PizzaMenu.ClamPizza:
                    pizza = new ClamPizza(_pizzaIngredientFactory);
                    break;
                case PizzaMenu.PepperoniPizza:
                    pizza = new PepperoniPizza(_pizzaIngredientFactory);
                    break;
                case PizzaMenu.VeggiePizza:
                    pizza = new VeggiePizza(_pizzaIngredientFactory); 
                    break;
            }
            return pizza;
        }
    }
}
