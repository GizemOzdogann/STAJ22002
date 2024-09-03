using FarmManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManager.Entities;

namespace FarmManager.UI
{
    public class Store
    {
        private readonly List<Animal> _animalList = [];
        private readonly List<Product> _productList = [];

        public IReadOnlyList<Animal> AnimalList => _animalList.AsReadOnly();
        public IReadOnlyList<Product> ProductList => _productList.AsReadOnly();

        #region Animals

        public void AddAnimal(Animal animal) => _animalList.Add(animal);
        public void RemoveAnimal(Animal animal) => _animalList.Remove(animal);
        public List<Animal> GetAnimals() => _animalList;

        public Dictionary<Type, int> GetAnimalCountByType()
        {
            return _animalList.GroupBy(p => p.GetType())
                                    .ToDictionary(g => g.Key, g => g.Count());
        }

        #endregion Animals

        #region Products

        public void AddProduct(Product product) => _productList.Add(product);
        public List<Product> GetProducts() => _productList;
        public int GetTotalOfProducts() => _productList.Count;
        public Dictionary<Type, int> GetProductCountByType()
        {
            return _productList.GroupBy(p => p.GetType())
                                     .ToDictionary(g => g.Key, g => g.Count());
        }

        #endregion Products

    }
}

