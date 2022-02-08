using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Memory
{
    public class OrderRepository : IOrderRepository
    {
        private readonly List<Order> orders = new List<Order>();

        public Order Create()
        {
            int nextId = orders.Count + 1;
            var order = new Order(nextId, new OrderItem[0]);

            orders.Add(order);
            return order;
        }

        public Order GetById(int id)
        {
            // если не будет найден заказ с таким id то Сингл выбросит исключение, как и если их будет больше одного
            return orders.Single(order => order.Id == id);
        }

        public void Update(Order order)
        {
            ; // ничего не делает и работает правильно
        }
    }
}
