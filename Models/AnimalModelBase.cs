using FarmManager.Entities;
using FarmManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Models
{
    public abstract class AnimalModelBase
    {
        public Gender? Gender { get; set; }
        public int Age { get; set; }
        public int Id { get; set; }
        public Image? AnimalImage { get; set; }
        public string? AnimalName { get; set; }
        public ProgressBar ProductionBar { get; set; } = new();
        public ProgressBar LifeBar { get; set; } = new();
        public int LifeTick {get; set; }
        public int ProductTick { get; set; }
        public abstract Product Production();
        public abstract Image LoadImage();
    }
}
