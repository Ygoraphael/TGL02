using System;
using System.Collections.Generic;
using System.Globalization;
using TGL_POO.Entities;
using TGL_POO.Model;

namespace TGL_POO
{
    class Program
    {
        static void Main(string[] args)
        {

            
            //ExEmployee();


            //Polymorphism();


        }

        public static void ExEmployee()
        {
            List<Employee> list = new List<Employee>();

            Console.WriteLine("Enter the number of employees.");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Employees #{i} data:");
                Console.WriteLine("Outsoruced (y/n)?");
                char Outso = char.Parse(Console.ReadLine());
                Console.WriteLine("Name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Hours: ");
                int hours = int.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour:");
                double Valueperhour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (Outso == 'y')
                {
                    Console.WriteLine("Aditional charge");
                    double AdditionalCharge = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    list.Add(new OutSourcedEmployee(name, hours, Valueperhour, AdditionalCharge));
                }
                else
                {
                    list.Add(new Employee(name, hours, Valueperhour));
                }
            }

            Console.WriteLine("---------------------------");
            Console.WriteLine("Payments");
            Console.WriteLine("---------------------------");

            foreach(Employee emp in list)
            {
                Console.WriteLine(emp.Name + " - $" + emp.Payment().ToString("F2", CultureInfo.InvariantCulture));
                
            }
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
