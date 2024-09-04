using FarmManager.Data;
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
        private readonly FarmManagerContext _context;

        public AnimalService(FarmManagerContext context)
        {
            _context = context;
        }

        public void AddAnimal(Animal animal)
        {
            _context.Animals.Add(animal);
            _context.SaveChanges();
        }

        public void RemoveAnimal(Animal animal)
        {
            _context.Animals.Remove(animal);
            _context.SaveChanges();
        }
        public List<Animal> GetAllAnimals()
        {
            return _context.Animals.ToList();
        }
    }
}
