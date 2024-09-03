using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Interfaces
{
    public interface IAnimalService
    {
        void AddAnimal(IAnimal animal);
        //void UpdateAnimal(IAnimal animal);
        void RemoveAnimal(int id);
        IAnimal? GetAnimalById(int id);
        int GetAllAnimals();

    }
}
