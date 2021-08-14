using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
    public interface Car
    {
        void read(string name);
        void display(string name);
    }

    class Car1 : Car
    {
        public void read(string name)
        {
            Console.WriteLine($"The car name is {name}");
        }
        public void display(string name)
        {
            Console.WriteLine($"The cost of {name} is 20L");
        }
    }
    class Program4
    {
        public static void Main()
        {
            Car1 c = new Car1();
            c.read("Harrier");
            c.display("Safari");

        }
    }
}
