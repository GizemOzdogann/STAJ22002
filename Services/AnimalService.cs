using FarmManager.Entities;
using FarmManager.Interfaces;
using FarmManager.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmManager.Services
{
    public class AnimalService : IAnimalService
    {
        private readonly Store _store;

        public AnimalService(Store store)
        {
            _store = store;
        }

        public void AddAnimal(Animal animal)
        {
            _store.AddAnimal(animal);
        }

        public void RemoveAnimal(Animal animal)
        {
            _store.RemoveAnimal(animal);
        }

        public IAnimal? GetAnimalById(int id)
        {
            return _store.GetAnimals().FirstOrDefault(a => a.Id == id);
        }

        public int GetAnimalCountByType()
        {
            return _store.GetAnimalCountByType().Sum(p => p.Value);
        }

        public int GetAllAnimals()
        {
            return _store.GetAnimals().Count;
        }
    }
}
