using CodeFirstApproach.Data;
using CodeFirstApproach.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeFirstApproach
{
    class Assignment_Day02
    {
        static void Main()
        {
            /*AddNewBook();*/
            AddNewCustomerAndOrder_ASGN();
            /*AddNewOrdersToCustomerID(3);*/
        }

        private static void AddNewOrdersToCustomerID(int v)
        {
            var ctx = new Context();
            Customer custobj = ctx.Customers.Where(c => c.ID == v).SingleOrDefault();
            Order ord = new Order();
            ord.Order_ID = 7;
            ord.Amount = 500;
            ord.OrderDate = DateTime.Now;

            /*List<Order> custorders = new List<Order>;
            custorders = custobj.Orders.S;
            Console.WriteLine(custorders);*/

            ord.cust = custobj;

            try
            {
                ctx.Orders.Add(ord);
                ctx.SaveChanges();
                Console.WriteLine("New Order Added to Customer");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }

        }

        private static void AddNewCustomerAndOrder_ASGN()
        {
            var ctx = new Context();
            Customer newcust = new Customer();
            newcust.ID = 4;
            newcust.Name = "Sachin";

            Order ord = new Order();
            ord.Order_ID = 2;
            ord.Amount = 100;
            ord.OrderDate = DateTime.Now;

            Order ord2 = new Order();
            ord2.Order_ID = 3;
            ord2.Amount = 105;
            ord2.OrderDate = DateTime.Now;

            /*Order ord3 = new Order();
            ord3.Order_ID = 4;
            ord3.Amount = 900;
            ord3.OrderDate = DateTime.Now;*/

            List<Order> myorders = new List<Order>
            {
                ord,
                ord2,
                /*ord3*/
            };
            newcust.orders = myorders;

            try
            {
                //ctx.Orders.Add(ord);
                ctx.Customers.Add(newcust);
                ctx.SaveChanges();
                Console.WriteLine("Customer and Order Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }
    }
}
