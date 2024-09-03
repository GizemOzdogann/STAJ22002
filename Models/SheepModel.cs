using FarmManager.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmManager.Models
{
    internal class SheepModel : AnimalModelBase
    {
        public SheepModel() 
        { 
            AnimalName = nameof(AnimalNames.Sheep);
            AnimalImage = LoadImage();
            LifeBar.Maximum = 100;
            ProductionBar.Maximum = 50;
        }
        public override Image LoadImage()
        {
            return Image.FromFile("C:\\Users\\ozdog\\Projects\\FarmManager\\Assets\\sheep.png");
        }
    }   
}
