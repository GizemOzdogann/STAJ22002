using FarmManager.Entities;
using FarmManager.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FarmManager.UI;

namespace FarmManager.Models
{
    internal class CowModel : AnimalModelBase
    {
        public CowModel() 
        { 
            AnimalName = Convert.ToString(AnimalNames.Cow);
            AnimalImage = LoadImage();
            LifeBar.Minimum = 0;
            ProductionBar.Maximum = 75;
        }
        
        public override Image LoadImage()
        {
            return Image.FromFile("C:\\Users\\ozdog\\Projects\\FarmManager\\Assets\\cow.png");
        }
    }
    
    



}
