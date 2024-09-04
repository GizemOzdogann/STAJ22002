using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManager.Entities;

namespace FarmManager.Interfaces
{
    public interface IAnimalService
    {
        void AddAnimal(Animal animal);
        void RemoveAnimal(Animal animal);
        List<Animal> GetAllAnimals();

    }
}
