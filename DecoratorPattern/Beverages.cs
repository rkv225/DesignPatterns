using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Espresso : Beverage
    {
        public Espresso()
        {
            this.Description = "Espresso";
        }

        public override double Cost()
        {
            return 1.99;
        }
    }

    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            this.Description = "House Blend";

        }
        public override double Cost()
        {
            return 0.89;
        }
    }

    public class DarkRoast : Beverage
    {
        public DarkRoast()
        {
            this.Description = "Dark Roast";
        }
        public override double Cost()
        {
            return 0.99;
        }
    }

    public class Decaf : Beverage
    {
        public Decaf()
        {
            this.Description = "Decaf";
        }
        public override double Cost()
        {
            return 1.05;
        }
    }
}
