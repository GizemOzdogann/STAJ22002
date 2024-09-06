using FarmManager.Interfaces;
using FarmManager.UI;
using FarmManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Services
{
    public class ProductService
    {
        public readonly Store _store;

        public ProductService(Store store)
        {
            _store = store;
        }

        public void AddProduct(Product product)
        {
            if (product is Product p)
            {
                _store.AddProduct(p);
            }
        }

        public void UpdateProducts(Product product, int Amount)
        {
            if (product != null)
            { 
                product.Quantity += Amount;

                if (product.Quantity <= 0)
                {
                    product.Quantity = 0;
                }
            }
        }
        public int GetProductCount<Product>() 
        {
            var productCounts = _store.GetProductCountByType();
            return productCounts.TryGetValue(typeof(Product), out int count) ? count : 0;
        }
        public int GetTotal()
        {
            return _store.GetTotalOfProducts();
        }
        public IEnumerable<IProduct> GetAllProducts()
        {
            return _store.GetProducts();
        }
    }
}