using FactoryMethodPattern.PizzaStores;
using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IPizza pizza = null;
            IPizzaStore pizzaStore = null;
            
            pizzaStore = new NYPizzaStore();
            
            pizza = pizzaStore.OrderPizza(PizzaMenu.VeggiePizza);
            Console.WriteLine(pizza);

            pizza = pizzaStore.OrderPizza(PizzaMenu.PepperoniPizza);
            Console.WriteLine(pizza);

            pizzaStore = new ChicagoPizzaStore();

            pizza = pizzaStore.OrderPizza(PizzaMenu.CheesePizza);
            Console.WriteLine(pizza);

            pizza = pizzaStore.OrderPizza(PizzaMenu.ClamPizza);
            Console.WriteLine(pizza);
        }
    }
}
