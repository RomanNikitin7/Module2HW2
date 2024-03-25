using Module2HW2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Repositories
{
    internal class OrderRepository
    {
        private Order[] _data;

        public OrderRepository()
        {
            _data = new Order[0];
        }

        public Order Save(Order order)
        {
            var id = _data.Length + 1;
            order.Id = id;
            var items = new Order[_data.Length + 1];
            Array.Copy(_data, items, _data.Length);
            items[items.Length - 1] = order;
            _data = items;
            return order;
        }
    }
}
