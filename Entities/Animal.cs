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
        public virtual string Type { get; set; } = " ";
        public Gender? Gender { get; set; }
        public int Age { get; set; }
        public virtual int LifeTick { get; set; } = 1;
        public virtual int ProductTick { get; set; } = 1;
    }
    public class Cow : Animal
    {
        public Cow()
        {
            Type = AnimalType.Cow.ToString();
            LifeTick = 1;
            ProductTick = 19;
        }
    }
    public class Chicken : Animal
    {
        public Chicken()
        {
            Type = AnimalType.Chicken.ToString();
            LifeTick = 2;
            ProductTick = 25;
        }
    }
    public class Sheep : Animal
    {
        public Sheep()
        {
            Type = AnimalType.Sheep.ToString();
            LifeTick= 2;
            ProductTick = 20;
        }
    }
    public enum AnimalType
    {
        Cow,
        Chicken,
        Sheep,
    }
}
