using System;
using OpenClosed_1.Data.Model;

namespace OpenClosed_1.Data
{
    class Program
    {
        static void Main(string[] args)
        {
            var user = new User { Id = 1, Name = "Name" };
            user.AddOrder(new Order { OrderNumber = 1, Type = OrderType.Normal, Price = 100, Quantity = 2 });
            user.AddOrder(new Order { OrderNumber = 1, Type = OrderType.Discount, Price = 200, Quantity = 2 });
            user.AddOrder(new Order { OrderNumber = 1, Type = OrderType.Urgent, Price = 10, Quantity = 10 });

            Console.WriteLine(user.GetTotalSum());
            Console.ReadLine();
        }
    }
}
