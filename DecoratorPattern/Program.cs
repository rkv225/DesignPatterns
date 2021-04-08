using System;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starbuzz Coffee");

            Beverage beverage = new Espresso();
            Console.WriteLine($"{beverage.Description} : ${beverage.Cost()}");

            Beverage beverage1 = new DarkRoast();
            beverage1 = new Mocha(beverage1);
            beverage1 = new Mocha(beverage1);
            beverage1 = new Whip(beverage1);
            Console.WriteLine($"{beverage1.Description} : ${beverage1.Cost()}");

            Beverage beverage2 = new HouseBlend();
            beverage2 = new Soy(beverage2);
            beverage2 = new Mocha(beverage2);
            beverage2 = new Whip(beverage2);
            Console.WriteLine($"{beverage2.Description} : ${beverage2.Cost()}");
        }
    }
}
