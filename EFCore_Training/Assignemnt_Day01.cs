using System;
using System.Linq;
using EFCore_Training.Models;

namespace EFCore_Training
{
    class Assignemnt_Day01
    {

        public static void Main()
        {
            /*GetEmployeesByDept(10);*/
            GetMaxSalOfEmployees();
            /*GetSalSumByDept(20);*/
            /*GetEmployeesWithStartingLetter("j");*/
        }

        private static void GetEmployeesWithStartingLetter(string v)
        {
            var ctx = new tcq_training1Context();
            var emps = ctx.Emps.Where(e => e.Ename.StartsWith(v));
            foreach (var e in emps)
            {
                Console.WriteLine(e.Ename);
            }
        }

        private static void GetSalSumByDept(int v)
        {
            var ctx = new tcq_training1Context();
            var salsum = ctx.Emps.Where(e => e.Deptno == v).Sum(e => e.Sal);
            Console.WriteLine(salsum);
        }

        private static void GetMaxSalOfEmployees()
        {
            var ctx = new tcq_training1Context();
            var maxsal = ctx.Emps.Max(e => e.Sal);
            Console.WriteLine(maxsal);
        }

        private static void GetEmployeesByDept(int deptno)
        {
            var ctx = new tcq_training1Context();
            var emps = ctx.Emps.Where(e => e.Deptno == deptno);
            foreach (var e in emps)
            {
                Console.WriteLine(e.Ename + " " + e.Deptno);
            }
        }
    }
}
