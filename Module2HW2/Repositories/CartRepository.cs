using Module2HW2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Repositories
{
    internal class CartRepository
    {
        private Cart[] _data;

        public CartRepository()
        {
            _data = new Cart[0];
        }
        public void Save(Cart cart)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Id == cart.Id)
                {
                    _data[i] = cart;
                    return;
                }
            }

            ResizeData(cart, cart.Id);
        }
        public Cart Get(int id)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Id == id)
                {
                    return _data[i];
                }
            }

            ResizeData(null, id);

            return _data[_data.Length - 1];
        }

        private void ResizeData(Cart cart, int id)
        {
            var items = new Cart[_data.Length + 1];
            Array.Copy(_data, items, _data.Length);
            if (cart == null)
            {
                items[items.Length - 1] = new Cart { Id = id, Items = new Product[0] };
            }
            else
            {
                items[_data.Length - 1] = cart;
            }
            _data = items;
        }
    }
}
