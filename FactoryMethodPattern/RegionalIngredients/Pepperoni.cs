using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RegionalIngredients
{
    public class SlicedPepperoni : Pepperoni
    {
        public override string ToString()
        {
            return "Sliced Pepperoni";
        }
    }
}
