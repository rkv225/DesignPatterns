using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RegionalIngredients
{
    public class FreshClams : Clams
    {
        public override string ToString()
        {
            return "Fresh Clams";
        }
    }
    public class FrozenClams : Clams
    {
        public override string ToString()
        {
            return "Frozen Clams";
        }
    }
}
