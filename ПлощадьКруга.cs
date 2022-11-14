using System;

namespace NewLibrary
{
    public class Circle
    {
        public double radius { get; set; }
        public Circle(double r)
        {
            radius = r;
        }
        public override double GetArea()
        {
            Area = Math.PI*Math.Pow(radius,2);
            return Area;
        }
    }
}