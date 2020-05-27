using System;

namespace PatternDecorator
{
    class Program
    {
        static void Main(string[] args)
        {
            var pizza = new LargePizza();
            var cheese = new CheeseDecorator(pizza); var tomato = new TomatoDecorator(cheese);
            Console.WriteLine($"Decorator Pattern Pizza: {tomato.GetDescription()} - {tomato.CalculateCost()}");
        }
    }
}
