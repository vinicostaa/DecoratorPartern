using System;
namespace PatternDecorator
{
    public class LargePizza : Pizza
    {
        public LargePizza() { Description = "Large Pizza"; }
        public override double CalculateCost()
        {
            return 45.00;
        }
        public override string GetDescription()
        {
            return Description;
        }
    }
}
