using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RegionalIngredients
{
    public class MarinaraSauce : Sauce
    {
        public override string ToString()
        {
            return "Marinara Sauce";
        }
    }
    public class PlumTomatoSauce : Sauce
    {
        public override string ToString()
        {
            return "Plum Tomato Sauce";
        }
    }
}
