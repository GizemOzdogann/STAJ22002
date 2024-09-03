using FarmManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Entities
{
    public class Product : IProduct
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
    }
    public class Milk : Product { }
    public class Meat : Product { }
    public class Egg : Product { }
}
