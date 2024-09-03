using FarmManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Entities
{
    public class Animal : IAnimal
    {
        public int Id { get; set; }
        public string? Gender { get; set; }
        public int Age { get; set; }
        public virtual int LifeSpan { get; } = 0;
        public virtual int lifeTick { get; set; } = 1;
        public virtual int productTick { get; set; } = 1;
    }
    public class Cow : Animal
    {
        public override int lifeTick { get; set; } = 1;
        public override int productTick { get; set; } = 5;
    }
    public class Chicken : Animal
    {
        public override int lifeTick { get; set; } = 2;
        public override int productTick { get; set; } = 3;
    }
    public class Sheep : Animal
    {
        public override int lifeTick { get; set; } = 3;
        public override int productTick { get; set; } = 4;
    }

    public enum AnimalNames
    {
        Cow,
        Chicken,
        Sheep,
    }

}
