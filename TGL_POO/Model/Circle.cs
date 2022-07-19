using System;

namespace TGL_POO.Model
{
    class Circle : Figure
    {
        public double Radius { get; }

        public Circle(double radius)
        {
            Radius = radius;
        }
        public override double Calculate_Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        public override double Calculate_Perimeter()
        {
            return Math.PI * Radius;
        }

        public new string ToString()
        {
            return $" Circle Area: {Calculate_Area()}, Circle Perimeter: { Calculate_Perimeter()}";
        }
    }
}
