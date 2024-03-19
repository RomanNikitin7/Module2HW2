using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Entities
{
    internal class Cart
    {
        public int Id { get; set; }
        public Product[] Items { get; set; }
        public double TotalPrice { get; set; }
    }
}
