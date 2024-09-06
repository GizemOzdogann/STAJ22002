using FarmManager.Data;
using FarmManager.Entities;
using FarmManager.Interfaces;
using FarmManager.UI;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FarmManager.Services
{
    public class AnimalService
    {
        private readonly FarmManagerContext _context;

        public AnimalService(FarmManagerContext context)
        {
            _context = context;
        }

        public async Task AddAnimal(Animal animal)
        {
            await _context.Animals.AddAsync(animal);
            await _context.SaveChangesAsync();
        }

        public async Task RemoveAnimal(Animal animal)
        {
            _context.Animals.Remove(animal);
            await _context.SaveChangesAsync();
        }
        public async Task<List<Animal>> GetAllAnimals()
        {
            return await _context.Animals.ToListAsync();
        }
    }
}
