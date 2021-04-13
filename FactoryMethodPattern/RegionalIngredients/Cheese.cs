using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RegionalIngredients
{
    public class ReggianoCheese : Cheese
    {
        public override string ToString()
        {
            return "Reggiano Cheese";
        }
    }

    public class MozarellaCheese : Cheese
    {
        public override string ToString()
        {
            return "Mozarella Cheese";
        }
    }

    public class ParmesanCheese : Cheese
    {
        public override string ToString()
        {
            return "Parmesan Cheese";
        }
    }
}
