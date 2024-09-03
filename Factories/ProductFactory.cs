using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManager.Entities;

namespace FarmManager.Factories
{
    public abstract class ProductFactory
    {
        public static Product GetProductFactory(Animal animal)  
        {
            return animal switch
            {
                Cow => new Milk(),
                Chicken => new Egg(),
                Sheep => new Milk(),
                _ => throw new ArgumentException("Invalid animal type", nameof(animal))
            };
        }
    }
}
