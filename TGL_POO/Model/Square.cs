using System;


namespace TGL_POO.Model
{
    class Square : Rectangle
    {
        public Square(double a):base(a, a)
        {
        }

        public override string ToString()
        {
            return $" Square: {Calculate_Area()}, { Calculate_Perimeter()}";
        }
    }
}
