﻿using System;
namespace PatternDecorator
{
    public class CheeseDecorator : PizzaDecorator
    {
        public CheeseDecorator(Pizza pizza) : base(pizza)
        {
            Description = "Cheese";
        }

        public override double CalculateCost()
        {
            return base.CalculateCost() + 1.25;
        }

        public override string GetDescription()
        {
            return $"{base.GetDescription()}, {Description}";
        }
    }
}
