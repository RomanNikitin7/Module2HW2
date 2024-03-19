using Module2HW2.Entities;
using Module2HW2.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Services
{
    internal class ProductService
    {
        private ProductRepository _repository;
        public ProductService(ProductRepository repository)
        {
            _repository = repository;
        }

        public Product[] Get()
        {
            return _repository.GetAll();
        }
    }
}
