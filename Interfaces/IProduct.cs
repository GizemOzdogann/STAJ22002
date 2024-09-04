using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Interfaces
{
    public interface IProduct
    {
        public int Id { get; set; }
        string? Name { get; set; }
        int Price { get; set; }
        public int Quantity { get; set; }

    }
}
