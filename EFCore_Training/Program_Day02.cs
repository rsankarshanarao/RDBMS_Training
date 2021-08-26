using CodeFirstApproach.Data;
using CodeFirstApproach.Models;
using System;
using System.Data.Entity;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main()
        {
            /*AddNewBook();*/
            /*AddNewCustomerAndOrder();*/
            /*GetAllCustomerDetailsWithOrders_EagerLoading();*/
            /*DeleteOrderByOrderID(7);*/
            /*DeleteAllOrdersOfCustomer(2);*/
            GetNumberOfOrdersByCustomer();
        }

        private static void GetNumberOfOrdersByCustomer()
        {
            var ctx = new Context();
            var numorders = ctx.Orders.GroupBy(o => o.cust.ID).Select(n => new
            {
                CustomerName = n.Key,
                Count = n.Count()
            }).ToList();
            /*var numorders = from o in ctx.Orders
                            group by o.*/

            foreach (var item in numorders)
            {
                Console.WriteLine(item.CustomerName + "    " + item.Count);
            }

        }

        private static void DeleteAllOrdersOfCustomer(int v)
        {
            var ctx = new Context();
            var customer = ctx.Customers.Where(c => c.ID == v).SingleOrDefault();
            var orders = ctx.Orders.Where(o => o.cust == customer);
            
            try
            {
                foreach(var order in orders)
                {
                    ctx.Orders.Remove(order);
                }
                ctx.SaveChanges();
                Console.WriteLine("Orders Deleted successfully");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException.ToString());
            }

        }

        private static void DeleteOrderByOrderID(int v)
        {
            var ctx = new Context();
            var order = ctx.Orders.Where(o => o.Order_ID == v).SingleOrDefault();
            try
            {
                ctx.Orders.Remove(order);
                ctx.SaveChanges();
                Console.WriteLine("Order Delted");
            }
            catch (Exception ex)
            {
                Console.WriteLine();
            }
        }

        private static void GetAllCustomerDetailsWithOrders_EagerLoading()
        {
            var ctx = new Context();
            try
            {
                /*var customers = ctx.Customers.Include("orders");*/
                /*var customers = ctx.Customers.Include(c => c.orders);*/

                var customers = ctx.Customers;

                foreach (var customer in customers)
                {
                    Console.WriteLine(customer.Name);
                    Console.WriteLine("----->");

                    ctx.Entry(customer).Collection(o => o.orders).Load();

                    foreach (var order in customer.orders)
                    {
                        Console.WriteLine("        " + order.OrderDate.ToString() +
                            "  " + order.Amount.ToString());
                    }
                    Console.WriteLine("-------------------------------");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }

        private static void AddNewCustomerAndOrder()
        {
            var ctx = new Context();
            Customer newcust = new Customer();
            newcust.ID = 1;
            newcust.Name = "Sankarshan";

            Order ord = new Order();
            ord.Order_ID = 1;
            ord.Amount = 200;
            ord.OrderDate = DateTime.Now;

            //List<Order> myorders = new List<Order>();
            //myorders.Add(ord);
            //newcust.Orders = myorders;

            try
            {
                ctx.Orders.Add(ord);
                ctx.Customers.Add(newcust);
                ctx.SaveChanges();
                Console.WriteLine("Customer and Order Added");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.InnerException.ToString());
            }
        }

        private static void AddNewBook()
        {
            var ctx = new Context();
            Book book = new Book();
            book.BookID = 1;
            book.BookName = "EF Core";
            book.Price = 120;
            try
            {
                ctx.Books.Add(book);
                ctx.SaveChanges();
                Console.WriteLine("New Book Added");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.InnerException.ToString());
            }
        }
    }
}
