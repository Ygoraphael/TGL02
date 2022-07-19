using System;


namespace TGL_POO.Model
{
    class Rectangle : Figure
    {
        public double A { get; }
        public double B { get; }

        public Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }
        public override double Calculate_Area()
        {
            return A * B;
        }

        public override double Calculate_Perimeter()
        {
            return 2 * (A + B);
        }

        public new virtual string ToString()
        {
            return $" Rectangle: {Calculate_Area()}, { Calculate_Perimeter()}";
        }
    }
}
