using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
    /// <summary>
    /// Structure User Definition
    /// </summary>
    struct User
    {
        public string name;
        public string sex;
        public float height;
        public float weight;

        /// <summary>
        /// Method to Store Values for the object
        /// </summary>
        /// <param name="name">Name</param>
        /// <param name="sex">SEX</param>
        /// <param name="height">Height</param>
        /// <param name="weight">Weight</param>
        public void getValues(string name, string sex, float height, float weight)
        {
            this.name = name;
            this.sex = sex;
            this.height = height;
            this.weight = weight;
        }
        /// <summary>
        /// Method to Display the Value of the objects
        /// </summary>
        /// <returns>String of Information</returns>
        public string display()
        {
            return "Name:" + name + "  Sex:" + sex + "  Height:" + height + "cm  Weight:" + weight + "kgs";
        }
    }
    class Program1
    {
        public static void Main()
        {
            User p = new User();
            p.getValues("Sankarshana", "Male", 180, 75);
            Console.WriteLine(p.display());
        }
    }
}

