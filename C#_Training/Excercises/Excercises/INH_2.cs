using System;
using System.Collections.Generic;
using System.Text;

namespace Excercises
{
    /// <summary>
    /// Class Employee
    /// </summary>
    class Employee
    {
        int rollNo { get; set; }
        string name { get; set; }
        string address { get; set; }
        string pincode { get; set; }
        string phoneNo { get; set; }
        float grossSal { set; get; }
        float pf { get; set; }
        float netSal { get; set; }
        /// <summary>
        /// Constructor to Create Employee Object
        /// </summary>
        /// <param name="l_rollno">Roll NO</param>
        /// <param name="l_name">Name</param>
        /// <param name="l_address">Address</param>
        /// <param name="l_pincode">Picode</param>
        /// <param name="l_phoneno">Phone Number</param>
        /// <param name="l_grossSal">Gross Salary</param>
        /// <param name="l_pf">PF</param>
        public Employee(int l_rollno, string l_name, string l_address, string l_pincode, string l_phoneno, float l_grossSal, float l_pf)
        {
            rollNo = l_rollno;
            name = l_name;
            address = l_address;
            pincode = l_pincode;
            phoneNo = l_phoneno;
            grossSal = l_grossSal;
            pf = l_pf;
        }
        /// <summary>
        /// Method to Display Salary
        /// </summary>
        /// <returns>Salary Info as a String</returns>
        public string displaySal()
        {
            netSal = grossSal - pf;
            if (netSal > 10000)
            {
                return "The net salary is " + netSal + "\n Grade A";
            }
            else if (netSal > 5000)
            {
                return "The net salary is " + netSal + "\n Grade B";
            }
            else
                return "The net salary is " + netSal + "\n Grade C";
        }

    }
    class Program2
    {
        public static void Main()
        {
            Employee e = new Employee(1, "Sankarshana", "Bangalore", "560085", "9066774590", 50000, 10000);
            Console.WriteLine(e.displaySal());
        }
    }
}