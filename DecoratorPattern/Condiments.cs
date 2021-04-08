using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public class Mocha : CondimentDecorator
    {
        public Mocha(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string Description 
        {
            get 
            {
                return this.Beverage.Description + ", Mocha";
            }
        }

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.20;
        }
    }

    public class SteamedMilk : CondimentDecorator
    {
        public SteamedMilk(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return this.Beverage.Description + ", Steamed Milk";
            }
        }

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.10;
        }
    }

    public class Soy : CondimentDecorator
    {
        public Soy(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return this.Beverage.Description + ", Soy";
            }
        }

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.15;
        }
    }

    public class Whip : CondimentDecorator
    {
        public Whip(Beverage beverage)
        {
            this.Beverage = beverage;
        }

        public override string Description
        {
            get
            {
                return this.Beverage.Description + ", Whip";
            }
        }

        public override double Cost()
        {
            return this.Beverage.Cost() + 0.10;
        }
    }
}
