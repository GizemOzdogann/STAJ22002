using FarmManager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmManager.UI
{
    public partial class ListItem : UserControl
    {
        public AnimalModelBase AnimalModel { get; }
        public ListItem(AnimalModelBase animalModel)
        {
            InitializeComponent();
            AnimalModel = animalModel;
            pictureBox.Image = animalModel.AnimalImage;
            label1.Text = animalModel.AnimalName ?? "Unknown";
            LifeBar.Value = animalModel.LifeBar.Value;
            ProductionBar.Value = animalModel.ProductionBar.Value;
        }
    }
}
