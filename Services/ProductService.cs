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
    internal class ProductService : IProductService
    {
        public readonly Store _store;

        public ProductService(Store store)
        {
            _store = store;
        }

        public void AddProduct(IProduct product)
        {
            if (product is Product p)
            {
                _store.AddProduct(p);
            }
        }

        public void UpdateProducts(string productName, int decAmount)
        {
            var eProduct = _store.GetProducts().FirstOrDefault(p => p.Name == productName);

            if (eProduct != null)
            {
                eProduct.Quantity -= decAmount;

                if (eProduct.Quantity <= 0)
                {
                    eProduct.Quantity = 0;
                }
            }
        }
        public int GetProductCountByType()
        {
            return _store.GetProductCountByType().Sum(p => p.Value);
        }

        public IEnumerable<IProduct> GetAllProducts()
        {
            return _store.GetProducts();
        }
    }
}
