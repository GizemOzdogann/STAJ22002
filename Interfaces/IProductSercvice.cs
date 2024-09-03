using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Interfaces
{
    public interface IProductService
    {
        void AddProduct(IProduct product);
        void UpdateProducts(string productName, int decreaseAmount);
        IEnumerable<IProduct> GetAllProducts();
    }
}
