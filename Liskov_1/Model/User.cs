using System.Collections.Generic;
using System.Linq;

namespace Liskov_1.Model
{
    public class User : IEntity
    {
        public long Id { get; set; }
        public string Name { get; set; }

        private readonly ICollection<Order> _orders;

        public User()
        {
            _orders = new HashSet<Order>();
        }

        public void AddOrder(Order order)
        {
            _orders.Add(order);
        }

        public decimal GetTotalSum()
        {
            return _orders.OfType<PlaсedOrder>().Sum(order => order.GetSum());
        }
    }
}
