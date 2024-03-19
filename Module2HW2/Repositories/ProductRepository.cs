using Module2HW2.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Repositories
{
    internal class ProductRepository
    {
        public Product[] GetAll()
        {
            return new[]
            {
                new Product() { Id = 1, Name = "iPhone", Price = 1000 },
                new Product() { Id = 2, Name = "Samsung", Price = 750 },
                new Product() { Id = 3, Name = "Google", Price = 500 },
            };
        }
    }
}
