using System;
using System.Collections.Generic;
using TGL_POO.Model;

namespace TGL_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Polymorphism();
        }


        public static void NormalExec(){
            Circle c = new Circle(5);

            Console.WriteLine(c.Calculate_Area());
            Console.WriteLine(c.Calculate_Perimeter());

            Rectangle r = new Rectangle(4, 5);

            Console.WriteLine(r.Calculate_Area());
            Console.WriteLine(r.Calculate_Perimeter());

            Square s = new Square(5);

            Console.WriteLine(s.Calculate_Area());
            Console.WriteLine(s.Calculate_Perimeter());

            Triangle t = new Triangle(3, 4, 5);

            Console.WriteLine(t.Calculate_Area());
            Console.WriteLine(t.Calculate_Perimeter());
        }

        public static void Polymorphism()
        {
            List<Figure> figures = new List<Figure>
            {
                new Circle(5),
                new Rectangle(4,5),
                new Square(5),
                new Triangle(3,4,5)
            };

            /*foreach (var f in figures)
            {
                Console.WriteLine(f.Calculate_Perimeter());
                Console.WriteLine(f.Calculate_Area());                
            }*/

            foreach (var f in figures)
            {
                Console.WriteLine(f);
            }


            Circle c = figures[0] as Circle;
            Console.WriteLine(c.ToString());

            Figure c1 = new Circle(5);
            Console.WriteLine(c1.ToString());

            Figure s1 = new Square(5);
            Console.WriteLine(s1.ToString());

            Rectangle s2 = new Square(5);
            Console.WriteLine(s2.ToString());
        }
    }
}
