using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManager.Entities;
using FarmManager.Models;

namespace ManagerApp.Factories
{
    public abstract class AnimalFactory
    {
        public static AnimalModelBase GetModalFactory(AnimalType animalType)
        {
            return animalType switch
            {
                AnimalType.Cow => new CowModel(),
                AnimalType.Chicken => new ChickenModel(),
                AnimalType.Sheep => new SheepModel(),
                _ => throw new ArgumentException("Invalid animal type", nameof(animalType))
            };
        }

        public static Animal GetFactory(AnimalType animalType) 
        {
            return animalType switch
            {
                AnimalType.Cow => new Cow(),
                AnimalType.Chicken => new Chicken(),
                AnimalType.Sheep => new Sheep(),
                _ => throw new ArgumentException("Invalid animal type", nameof(animalType))
            };
        }
        public static Animal ToAnimal(AnimalModelBase animalModel)
        {
            return animalModel switch
            {
                CowModel => new Cow {},
                ChickenModel => new Chicken {},
                SheepModel => new Sheep {},
                _ => throw new ArgumentException("Invalid animal model type", nameof(animalModel))
            };
        }
    }
}
