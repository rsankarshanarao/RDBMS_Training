using System;
namespace Excercises
{
    public class Age
    {
        int age { get; set; }

        public Age(int l_age)
        {
            age = l_age;
        }
        public void displayAge()
        {
            if (age < 0)
            {
                throw (new AgeIsNegativeException("Age cannot be negative"));
            }
            else
            {
                Console.WriteLine("Age is: {0}", age);
            }
        }
    }
    class Program5
    {
        static void Main()
        {
            Age a = new Age(-5);
            try
            {
                a.displayAge();
            }
            catch (AgeIsNegativeException e)
            {
                Console.WriteLine("AgeIsNegativeException: {0}", e.Message);
            }
        }
    }
}