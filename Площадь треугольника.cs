using System;

namespace NewLibrary
{
    public class Triangle
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public Triangle(double a,double b,double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
            if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2))
            {
                Console.WriteLine("Треугольник прямоугольный");
            }
        }
        public override double GetArea()
        {
            double p = GetPerimeter()/2;
            Area = Math.Sqrt(p*(p-SideA)*(p - SideB) *(p - SideC));
            return Area;
        }

    }
}