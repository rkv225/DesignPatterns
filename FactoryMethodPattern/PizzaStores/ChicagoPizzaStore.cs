using System;
using System.Collections.Generic;
using System.Text;
using FactoryMethodPattern.IngredientFactory;
using FactoryMethodPattern.Pizzas;

namespace FactoryMethodPattern.PizzaStores
{
    public class ChicagoPizzaStore : PizzaStore
    {
        public ChicagoPizzaStore() : base(new ChicagoIngredientFactory())
        {
            this.StoreName = "Chicago";
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
