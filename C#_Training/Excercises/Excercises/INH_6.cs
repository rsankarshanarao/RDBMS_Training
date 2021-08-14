using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
    class Shape
    {
        public double length { get; set; }
        public double width { get; set; }
        public double radius { get; set; }

        public Shape(double l_length, double l_width)
        {
            length = l_length;
            width = l_width;

        }

        public Shape(double l_radius)
        {
            radius = l_radius;
        }

        public virtual void Area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of Shape is :" + area);
        }
    }
    class Rectangle : Shape
    {

        public Rectangle(double length, double width) : base(length, width)
        {
        }

        public override void Area()
        {
            double area = length * width;
            Console.WriteLine("Area of Rectangle is :" + area);
        }
    }


    class Circle : Shape
    {

        public Circle(double radius)
            : base(radius)
        {
        }

        public override void Area()
        {
            double area = Math.PI * radius;
            Console.WriteLine("Area of circle is :" +area);
        }
    }

    class Sphere : Shape
    {

        public Sphere(double radius) : base(radius)
        {
        }

        public override void Area()
        {
            double area = 4 * Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("Area of sphere is :" + area);
        }
    }
    class Program6
    {
        static void Main()
        {
            double length, width, radius;

            Console.WriteLine("Enter the radius ");
            radius = Double.Parse(Console.ReadLine());
            Circle CircleObj = new Circle(radius);
            CircleObj.Area();

            Sphere SphereObj = new Sphere(radius);
            SphereObj.Area();

            Console.WriteLine("Enter the length for rectangle");
            length = Double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the width for rectangle");
            width = Double.Parse(Console.ReadLine());

            Rectangle RectObj = new Rectangle(length, width);
            RectObj.Area();

            Console.Read();
        }
    }
}
