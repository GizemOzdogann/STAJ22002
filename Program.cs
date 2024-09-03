using Autofac;
using Autofac.Extensions.DependencyInjection;
using FarmManager.Interfaces;
using FarmManager.Models;
using FarmManager.Services;
using FarmManager.UI;
using ManagerApp.Factories;
using System;
using System.Windows.Forms;

namespace FarmManager
{
    internal static class Program
    {

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var container = ConfigureContainer();

            using ILifetimeScope scope = container.BeginLifetimeScope();
            var mainForm = scope.Resolve<MainForm>();

            Application.Run(mainForm);
        }

        private static IContainer ConfigureContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainForm>().AsSelf();
            builder.RegisterType<Store>().AsSelf().SingleInstance();
            builder.RegisterType<AnimalService>().As<IAnimalService>();
            builder.RegisterType<ProductService>().As<IProductService>();

            return builder.Build();
        }
    }
}