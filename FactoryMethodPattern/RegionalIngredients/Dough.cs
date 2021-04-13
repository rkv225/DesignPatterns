using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RegionalIngredients
{
    public class ThickCrustDough : Dough
    {
        public override string ToString()
        {
            return "Thick Crust Dough";
        }
    }
    public class ThinCrustDough : Dough
    {
        public override string ToString()
        {
            return "Thin Crust Dough";
        }
    }
}
