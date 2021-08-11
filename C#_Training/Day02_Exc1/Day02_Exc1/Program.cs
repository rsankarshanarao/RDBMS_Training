/*Circle is a class with property radius and methods setRadius(), \
getRadius(), calcDiameter(), calcArea().Use double precision for everything. 
Write appropriate driver program to test the methods. */
using System;

namespace Day02_Exc1
{
    /// <summary>
    /// Class Circle
    /// </summary>
    class Circle
    {
        double radius;
        /// <summary>
        /// Constructor to Create a circle with radius value 0
        /// </summary>
        public Circle()
        {
            radius = 0;
        }
        /// <summary>
        /// Constructor to create a circle object with radius input
        /// </summary>
        /// <param name="rad">Radius</param>
        public Circle(double rad)
        {
            radius = rad;
        }

        /// <summary>
        /// Method to set radius of a Circle object
        /// </summary>
        /// <param name="rad">Radius</param>
        public void SetRadius(double rad)
        {
            radius = rad;
        }

        /// <summary>
        /// Method to fetch radius of a circle object
        /// </summary>
        /// <returns></returns>
        public double GetRadius()
        {
            return this.radius;
        }

        /// <summary>
        /// Method to Fetch Diameter of a circle object
        /// </summary>
        /// <returns></returns>
        public double CalcDiameter()
        {
            return (2 * radius);
        }

        /// <summary>
        /// Method to fetch Area of a circle object
        /// </summary>
        /// <returns></returns>
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
