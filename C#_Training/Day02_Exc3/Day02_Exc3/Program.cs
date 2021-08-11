/*Create a class called EmployeeSalary with attributes as EmployeeId, name, 
Basic salary, HR allowance, Travel Allowant, % of income tax deduction. 
Provide appropriate visibility (private/public/protected/static)  of all the attributes. 
Create a constructor to accept employee salary details.*/

using System;

namespace Day02_Exc3
{
    class EmployeeSalary
    {
        public int EmployeeID;
        public string Name;
        float Basic_Salary;
        float HR_Allowance;
        float Travel_Allowance;
        public float IT_Deduction_Percent;
        /// <summary>
        /// Method to calculcate IT Deduction Percentage
        /// </summary>
        /// <param name="e">EmployeeSalary Object</param>
        /// <returns></returns>
        private float calcIT_Percent(EmployeeSalary e)
        {
            float totsal = e.Basic_Salary + e.HR_Allowance + e.Travel_Allowance;
            float annualsal = totsal * 12;
            float itp;
            if (annualsal < 500000.00)
            {
                itp = 0;
            }
            else if (annualsal < 1000000)
            {
                itp = 10;
            }
            else if (annualsal < 2000000)
            {
                itp = 20;
            }
            else
            {
                itp = 30;
            }

            return itp;
        }
        /// <summary>
        /// Constructor to create a EmployeeSalary Object
        /// </summary>
        /// <param name="eid">Employee ID</param>
        /// <param name="ename">Employee Name</param>
        /// <param name="ebsal">Basic Salary</param>
        /// <param name="ehra">HRA</param>
        /// <param name="eta">TA</param>
        public EmployeeSalary(int eid, string ename, float ebsal, float ehra, float eta)
        {
            EmployeeID = eid;
            Name = ename;
            Basic_Salary = ebsal;
            HR_Allowance = ehra;
            Travel_Allowance = eta;
            IT_Deduction_Percent = calcIT_Percent(this);
        }
        
        
    }
    class Program
    {
        static void Main()
        {
            EmployeeSalary e = new EmployeeSalary(1,"Sankarshana",20000,10000,10000);
            EmployeeSalary e1= new EmployeeSalary(2, "Emp 2", 25000, 15000, 15000);
            EmployeeSalary e2 = new EmployeeSalary(3, "Emp 2", 50000, 26000, 25000);
            EmployeeSalary e3 = new EmployeeSalary(4, "Emp 2", 100000, 50000, 35000);
            Console.WriteLine("Employee ID is " + e.EmployeeID + " With Name " + e.Name +
                " Whose IT Slab is " + e.IT_Deduction_Percent + "%");
            Console.WriteLine("Employee ID is " + e1.EmployeeID + " With Name " + e1.Name +
                " Whose IT Slab is " + e1.IT_Deduction_Percent + "%");
            Console.WriteLine("Employee ID is " + e2.EmployeeID + " With Name " + e2.Name +
                " Whose IT Slab is " + e2.IT_Deduction_Percent + "%");
            Console.WriteLine("Employee ID is " + e3.EmployeeID + " With Name " + e3.Name +
                " Whose IT Slab is " + e3.IT_Deduction_Percent + "%");
        }
    }
}
