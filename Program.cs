using Autofac;
using Autofac.Extensions.DependencyInjection;
using FarmManager.Data;
using FarmManager.Interfaces;
using FarmManager.Models;
using FarmManager.Services;
using FarmManager.UI;
using ManagerApp.Factories;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;
using Microsoft.Extensions.Logging;


namespace FarmManager
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var host = Host.CreateDefaultBuilder()
                .ConfigureAppConfiguration((context, config) =>
                {
                    config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
                })
                .ConfigureLogging(logging => { 

                    logging.ClearProviders();
                    logging.AddConsole();
                })
                .ConfigureServices((context, services) =>
                {
                    
                    services.AddDbContext<FarmManagerContext>(options =>
                        options.UseSqlServer(context.Configuration.GetConnectionString("FarmManagerDatabase"))
                        .EnableSensitiveDataLogging());
                })
                .UseServiceProviderFactory(new AutofacServiceProviderFactory())
                .ConfigureContainer<ContainerBuilder>(builder =>
                {
                    ConfigureContainer(builder);
                })
                .Build();

            using (var scope = host.Services.CreateScope())
            {
                // ensure created
                var context = scope.ServiceProvider.GetRequiredService<FarmManagerContext>();
                context.Database.EnsureCreated();
                context.Database.Migrate();

                var mainForm = scope.ServiceProvider.GetRequiredService<MainForm>();
                Application.Run(mainForm);
            }
        }

        private static void ConfigureContainer(ContainerBuilder builder)
        {
            builder.RegisterType<MainForm>().AsSelf();
            builder.RegisterType<Store>().AsSelf().SingleInstance();
            builder.RegisterType<AnimalService>().As<IAnimalService>();
            builder.RegisterType<ProductService>().As<IProductService>();

            builder.RegisterType<FarmManagerContext>()
                   .AsSelf()
                   .InstancePerLifetimeScope();
        }
    }
}