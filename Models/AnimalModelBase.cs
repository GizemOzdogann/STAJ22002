using FarmManager.Entities;
using FarmManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Models
{
    public abstract class AnimalModelBase : IAnimal
    {
        //public int Id { get; set; }
        //public string? Gender { get; set; }
        //public int Age { get; set; }
        //public int LifeSpan { get; protected set; }

        public Image? AnimalImage { get; set; }
        public string? AnimalName { get; set; }
        public ProgressBar ProductionBar { get; set; } = new();
        public ProgressBar LifeBar { get; set; } = new();
        public int lifeTick {get; set; }
        public int productTick { get; set; }
        public abstract Product Production();
        public abstract Image LoadImage();
    }
}
