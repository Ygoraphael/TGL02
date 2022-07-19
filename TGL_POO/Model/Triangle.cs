using System;
using TGL_POO.Model;

namespace TGL_POO.Model
{
    class Triangle : Figure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double Calculate_Area()
        {
            double p = Calculate_Perimeter();
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }

        public override double Calculate_Perimeter()
        {
            return A + B + C;
        }

        public override string ToString()
        {
            return $"Area: {Calculate_Area()}, Perimeter: { Calculate_Perimeter()}";
        }

    }
}
