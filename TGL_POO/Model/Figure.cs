using System;

namespace TGL_POO.Model { 

    public abstract class Figure
    {
        public abstract double Calculate_Area();
        public abstract double Calculate_Perimeter();

        public override string ToString()
        {
            return $"Perimeter: { Calculate_Perimeter()}, Area: {Calculate_Area()}";
        }
    }
}
