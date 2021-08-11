/*Circle is a class with property radius and methods setRadius(), \
getRadius(), calcDiameter(), calcArea().Use double precision for everything. 
Write appropriate driver program to test the methods. */
using System;

namespace Day02_Exc1
{
    class Circle
    {
        double radius;

        public Circle()
        {
            radius = 0;
        }
        public Circle(double rad)
        {
            radius = rad;
        }

        public void SetRadius(double rad)
        {
            radius = rad;
        }

        public double GetRadius()
        {
            return this.radius;
        }

        public double CalcDiameter()
        {
            return (2 * radius);
        }

        public double CalcArea()
        {
            return (3.14 * radius * radius);
        }
    }
    class Program
    {
        static void Main()
        {
            Circle c = new Circle();
            Console.WriteLine("For object 'c', before setting radius, Output of GetRadius: " + c.GetRadius() +
                ", CalcDiameter: "+ c.CalcDiameter() + ", CalcArea: " + c.CalcArea());
            Console.WriteLine("Using SetRadius with radius value 5 for c");
            c.SetRadius(5);
            Console.WriteLine("For object 'c', after setting radius, Output of GetRadius: " + c.GetRadius() +
                ", CalcDiameter: " + c.CalcDiameter() + ", CalcArea: " + c.CalcArea());

            Circle c1 = new Circle(10.2);
            Console.WriteLine("For object 'c1' with initial radius 10.2, before setting radius, Output of GetRadius: " + c1.GetRadius() +
                ", CalcDiameter: " + c1.CalcDiameter() + ", CalcArea: " + c1.CalcArea());
            Console.WriteLine("Using SetRadius with radius value 3.5 for c1");
            c1.SetRadius(3.5);
            Console.WriteLine("For object 'c1' with inital radius 10.2, after setting radius, Output of GetRadius: " + c1.GetRadius() +
                ", CalcDiameter: " + c1.CalcDiameter() + ", CalcArea: " + c1.CalcArea());
        }
    }
}
