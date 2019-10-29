using System;
using OpenClosed_3.Data.Model;

namespace OpenClosed_3.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Name" };
            user.AddOrder(new Order { OrderNumber = 1, Price = 100, Quantity = 2 });
            user.AddOrder(new DiscountOrder { OrderNumber = 1, Price = 200, Quantity = 2 });
            user.AddOrder(new UrgentOrder { OrderNumber = 1, Price = 10, Quantity = 10 });

            Console.WriteLine(user.GetTotalSum());
            Console.ReadLine();
        }
    }
}
