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

        public void Save(Cart cart)
        {
            for (int i = 0; i < _data.Length; i++)
            {
                if (_data[i].Id == cart.Id)
                {
                    _data[i] = cart;
                    break;
                }
            }
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

            return null;
        }
    }
}
