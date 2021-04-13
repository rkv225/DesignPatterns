using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public abstract class PizzaStore : IPizzaStore
    {
        public string StoreName { get; set; }

        protected readonly IPizzaIngredientFactory _pizzaIngredientFactory;
        protected abstract IPizza CreatePizza(PizzaMenu item);
        protected PizzaStore(IPizzaIngredientFactory pizzaIngredientFactory)
        {
            _pizzaIngredientFactory = pizzaIngredientFactory;
        }
        public IPizza OrderPizza(PizzaMenu item)
        {
            IPizza pizza = CreatePizza(item);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();
            pizza.Label(this.StoreName);
            return pizza;
        }
    }
}
