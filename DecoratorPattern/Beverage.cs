using System;
using System.Collections.Generic;
using System.Text;

namespace DecoratorPattern
{
    public abstract class Beverage
    {
        public virtual string Description { get; set; }
        public Beverage()
        {
            Description = "Unknown Beverage";
        }

        public abstract double Cost();
    }
}
