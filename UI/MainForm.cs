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

namespace FarmManager
{
    
    public partial class MainForm : Form
    {
        private readonly IAnimalService animalService;
        public MainForm(IAnimalService animalService)
        {
            InitializeComponent();
            InitializeTimer();
            progressTimer.Tick += progressTimer_Tick;
            this.animalService = animalService;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string? Animal = AnimalTypeComboBox.SelectedItem?.ToString();
            string? Gender = GenderPickComboBox.SelectedItem?.ToString();
            string? Age = AgeComboBox.SelectedItem?.ToString();


            if (!string.IsNullOrEmpty(Animal) && !string.IsNullOrEmpty(Gender) && !string.IsNullOrEmpty(Age))
            {
                try
                {
                    IAnimal animal = AnimalFactory.GetFactory(Animal);
                    animalService.AddAnimal(animal);
                    AnimalModelBase animalModel = AnimalFactory.GetModalFactory(Animal);
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

            else { MessageBox.Show("Please select animal type, gender, and age."); }

            ClearComboBoxes();
        }
        public void BindData(AnimalModelBase animalModel, ListItem listItem)
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

        //LifeTick 

        private void progressTimer_Tick(object? sender, EventArgs e)
        {
            foreach (ListItem item in flowLayoutPanel1.Controls)
            {
                // Decrease LifeBar based on lifeTick value, ensuring it doesn't drop below 0
                if (item.LifeBar.Value > 0)
                {
                    item.LifeBar.Value = Math.Max(0, item.LifeBar.Value - item.AnimalModel.lifeTick);
                }

                // Increase ProductionBar based on productTick value, ensuring it doesn't exceed the maximum
                if (item.ProductionBar.Value < item.ProductionBar.Maximum)
                {
                    item.ProductionBar.Value = Math.Min(item.ProductionBar.Maximum, item.ProductionBar.Value + item.AnimalModel.productTick);
                }
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            Thread progressThread = new Thread(new ThreadStart(UpdateProgressBar));
            progressThread.Start();
        }

        private int progressValue = 0;
        private void UpdateProgressBar()
        {
            while (progressValue <= 100)
            {
                if (this.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        if (circularProgressBar1 != null && circularProgressBar2 != null && circularProgressBar3 != null)
                        {
                            circularProgressBar1.Value = progressValue;
                            circularProgressBar2.Value = progressValue;
                            circularProgressBar3.Value = progressValue;
                        }
                    });
                }

                Thread.Sleep(500);

                progressValue++;
            }
        }
        private void UpdateListItemProgressBars(object sender, EventArgs e)
        {
            foreach (ListItem item in flowLayoutPanel1.Controls)
            {
                
                if (item.LifeBar.Value > 0)
                {
                    item.LifeBar.Value--;
                }

                if (item.ProductionBar.Value < item.ProductionBar.Maximum)
                {
                    item.ProductionBar.Value++;
                }
            }
        }
        private void InitializeTimer()
        {
            progressTimer.Interval = 1000;
            progressTimer.Tick += progressTimer_Tick;
            progressTimer.Start();
        }
    }
}
