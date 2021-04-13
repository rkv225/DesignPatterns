using FactoryMethodPattern.AbstractIngredients;
using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodPattern.RegionalIngredients
{
    public class Garlic : Veggies
    {
        public override string ToString()
        {
            return "Garlic";
        }
    }
    public class Onion : Veggies
    {
        public override string ToString()
        {
            return "Onion";
        }
    }
    public class Mushroom : Veggies
    {
        public override string ToString()
        {
            return "Mushroom";
        }
    }
    public class RedPepper : Veggies
    {
        public override string ToString()
        {
            return "RedPepper";
        }
    }
    public class BlackOlives : Veggies
    {
        public override string ToString()
        {
            return "Black Olives";
        }
    }
    public class Spinach : Veggies
    {
        public override string ToString()
        {
            return "Spinach";
        }
    }
    public class EggPlant : Veggies
    {
        public override string ToString()
        {
            return "EggPlant";
        }
    }
}
