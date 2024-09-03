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
        public static AnimalModelBase GetModalFactory(string animalType)
        {
            return animalType switch
            {
                "Cow" => new CowModel(),
                "Chicken" => new ChickenModel(),
                "Sheep" => new SheepModel(),
                _ => throw new ArgumentException("Invalid animal type", nameof(animalType))
            };
        }

        public static Animal GetFactory(string animalType) 
        {
            return animalType switch
            {
                "Cow" => new Cow(),
                "Chicken" => new Chicken(),
                "Sheep" => new Sheep(),
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
