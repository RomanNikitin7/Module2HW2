using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module2HW2.Entities
{
    internal class Buyer
    {
        public string Email { get; set; }
        public Order[] Orders {  get; set; }
    }
}
