using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManager.Entities;

namespace FarmManager.Interfaces
{ /// <summary>
/// /////////might delete later
/// </summary>
    public interface IProductService
    {
        void AddProduct(Product product);
        void UpdateProducts(Product product, int Amount);
        IEnumerable<IProduct> GetAllProducts();
        int GetTotal();
        public int GetProductCount<TProduct>();
    }
}
