using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManager.Entities;

namespace FarmManager.Interfaces
{
    public interface IAnimalService
    { /// <summary>
/// /////////might delete later
/// </summary>
        void AddAnimal(Animal animal);
        void RemoveAnimal(Animal animal);
        List<Animal> GetAllAnimals();

    }
}
