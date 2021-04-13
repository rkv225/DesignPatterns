using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern
{
    public interface IPizzaStore
    {
        IPizza OrderPizza(PizzaMenu item);
    }
}
