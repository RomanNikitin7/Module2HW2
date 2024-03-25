using Module2HW2.Entities;
using Module2HW2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Services
{
    internal class CartService
    {
        private CartRepository _repository;
        public CartService(CartRepository repository)
        {
            _repository = repository;
        }

        public Cart AddProduct(int cartId, Product product)
        {
            var cart = _repository.Get(cartId);
            var items = new Product[cart.Items.Length + 1];
            Array.Copy(cart.Items, items, cart.Items.Length);
            items[items.Length - 1] = product;
            cart.Items = items;
            cart.TotalPrice += product.Price;

            _repository.Save(cart);

            return cart;
        }
    }
}
