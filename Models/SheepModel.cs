﻿using FarmManager.Entities;
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
            AnimalName = nameof(AnimalType.Sheep);
            AnimalImage = LoadImage();

            LifeBar.Minimum = 0;
            LifeBar.Maximum = 100;
            LifeBar.Value = 100;

            ProductionBar.Minimum = 0;
            ProductionBar.Maximum = 100;
            ProductionBar.Value = 0;
        }

        public override Product Production()
        {
            return new Milk();
        }

        public override Image LoadImage()
        {
            return Image.FromFile("C:\\Users\\ozdog\\Projects\\FarmManager\\Assets\\sheep.png");
        }
    }   
}
