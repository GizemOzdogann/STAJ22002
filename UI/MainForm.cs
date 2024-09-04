using FarmManager.Entities;
using FarmManager.Interfaces;
using FarmManager.Models;
using FarmManager.Services;
using FarmManager.UI;
using ManagerApp.Factories;
using System.Reflection.Emit;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;
using ProgressBar = System.Windows.Forms.ProgressBar;
using MethodInvoker = System.Windows.Forms.MethodInvoker;
using System.Reflection;
using FarmManager.Factories;

namespace FarmManager
{
    public partial class MainForm : Form
    {
        private readonly IAnimalService animalService;
        private readonly IProductService productService;
        public MainForm(IAnimalService animalService, IProductService productService)
        {
            InitializeComponent();
            InitializeTimer();
            progressTimer.Tick += ProgressTimer_Tick;
            this.animalService = animalService;
            this.productService = productService;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string? Animal = AnimalTypeComboBox.SelectedItem?.ToString();
            string? Gender = GenderPickComboBox.SelectedItem?.ToString();
            string? Age = AgeComboBox.SelectedItem?.ToString();

            if (!string.IsNullOrEmpty(Animal) && !string.IsNullOrEmpty(Gender) && !string.IsNullOrEmpty(Age))
            {
                BindAnimal(Animal);

            }

            else { MessageBox.Show("Please select animal type, gender, and age."); }

            ClearComboBoxes();
        }

        private void BindAnimal(string animalType)
        {
            try
            {
                Animal animal = AnimalFactory.GetFactory(animalType);
                animalService.AddAnimal(animal);

                AnimalModelBase animalModel = AnimalFactory.GetModalFactory(animalType);

                animalModel.productTick = animal.productTick;
                animalModel.lifeTick = animal.lifeTick;
                
                ListItem listItem = new(animalModel) { Size = new(175, 249) };

                BindData(animalModel, listItem);

                flowLayoutPanel1.Controls.Add(listItem);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to add control: {ex.Message}");
            }

            flowLayoutPanel1.Refresh();
        }

        public static void BindData(AnimalModelBase animalModel, ListItem listItem)
        {
            listItem.pictureBox.Image = animalModel.AnimalImage;
            listItem.label1.Text = animalModel.AnimalName;

            listItem.LifeBar.Maximum = animalModel.LifeBar?.Maximum ?? 100;
            listItem.LifeBar.Value = animalModel.LifeBar?.Value ?? 0;

            listItem.ProductionBar.Maximum = animalModel.ProductionBar?.Maximum ?? 100;
            listItem.ProductionBar.Value = animalModel.ProductionBar?.Value ?? 0;
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearComboBoxes()
        {
            AnimalTypeComboBox.SelectedIndex = -1;
            AgeComboBox.SelectedIndex = -1;
            GenderPickComboBox.SelectedIndex = -1;
        }

        private void ProgressTimer_Tick(object? sender, EventArgs e)
        {
            int itemCount = flowLayoutPanel1.Controls.Count;
            label3.Text = $"Total: {itemCount}";
            List<ListItem> itemsToRemove = new();

            foreach (ListItem item in flowLayoutPanel1.Controls)
            {
                Animal animal = AnimalFactory.ToAnimal(item.AnimalModel);
                Product product = ProductFactory.GetProductFactory(animal);

                item.LifeBar.Value = Math.Max(0, item.LifeBar.Value - animal.lifeTick);
                if (item.LifeBar.Value == 0)
                {
                    itemsToRemove.Add(item);
                    //circularProgressBar3.Value = Math.Min(circularProgressBar3.Maximum, circularProgressBar3.Value++);
                    circularProgressBar2.Value+=2;
                    productService.AddProduct(new Meat());
                }

                item.ProductionBar.Value = Math.Min(item.ProductionBar.Maximum, item.ProductionBar.Value + animal.productTick);
                
                if (item.ProductionBar.Value == 100)
                {
                    productService.AddProduct(product);
                    item.ProductionBar.Value = 0;
                }

                //label4.Text = $"Total: {productService.GetTotal()}";
                
                label8.Text = $"{productService.GetProductCount<Milk>()}";
                label9.Text = $"{productService.GetProductCount<Meat>()}";
                label10.Text = $"{productService.GetProductCount<Egg>()}";

                UpdateProgressBar(animal);
            }

            foreach (ListItem item in itemsToRemove)
            {
                flowLayoutPanel1.Controls.Remove(item);
                Animal animal = AnimalFactory.ToAnimal(item.AnimalModel);
                animalService.RemoveAnimal(animal);
                
            }
            
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            circularProgressBar1.Value = 0;
            circularProgressBar2.Value = 0;
            circularProgressBar3.Value = 0;
        }

        private int progressValue = 0;
        private int count = 1;
        private void UpdateProgressBar(Animal index)
        {
            if (progressValue < 100)
            {
                switch (index)
                {
                    case Cow:
                        circularProgressBar1.Value = progressValue++;
                        break;
                    case Sheep:
                        circularProgressBar1.Value = progressValue++;
                        break;
                    case Chicken:
                        circularProgressBar3.Value = progressValue++;
                        break;
                }
            }
            else if (progressValue == 100) 
            {
                progressValue = 0;
                label4.Text = $"Total: {count}";
                count++;
            }
                //Thread.Sleep(500);
                //progressValue++;
        }
        
        private void InitializeTimer()
        {
            progressTimer.Interval = 1000;
            progressTimer.Tick += ProgressTimer_Tick;
            progressTimer.Start();
        }
    }
}