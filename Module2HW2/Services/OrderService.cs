using Module2HW2.Entities;
using Module2HW2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Services
{
    internal class OrderService
    {
        private OrderRepository _repository;

        public OrderService (OrderRepository repository)
        {
            _repository = repository;
        }
        public Order Create(Cart cart)
        {
            var order = new Order()
            {
                Items = cart.Items,
                TotalPrice = cart.TotalPrice
            };

            return _repository.Save(order);
        }
    }
}
