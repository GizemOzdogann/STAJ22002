using FarmManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace FarmManager.Entities
{
    public class Animal : IAnimal
    {
        public int Id { get; set; }
        //public string? Gender { get; set; }
        //public int Age { get; set; }
        //public virtual int LifeSpan { get; } = 0;
        public virtual int lifeTick { get; set; } = 1;
        public virtual int productTick { get; set; } = 1;
        public virtual Product? Product { get; set; }
        public Animal() { }

        public Animal(Product product)
        {
            Product = product;
        }
    }
    public class Cow : Animal
    {
        public Cow() : base(new Milk())
        {
            lifeTick = 1;
            productTick = 19;
        }
    }
    public class Chicken : Animal
    {
        public Chicken() : base(new Egg())
        {
            lifeTick = 2;
            productTick = 25;
        }
    }
    public class Sheep : Animal
    {
        public Sheep() : base(new Milk())
        {
            lifeTick= 2;
            productTick = 20;
        }
    }
    public enum AnimalNames
    {
        Cow,
        Chicken,
        Sheep,
    }
}
