using Microsoft.Extensions.DependencyInjection;
using ProductivityServices.DependencyInjection;
using ProductivityServices.WPF.Features;
using System.Windows;

namespace ProductivityServices.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            DependencyInjectionContext.Update(services.BuildServiceProvider());
        }

        private void ConfigureServices(ServiceCollection services)
        {
            
            ProductivityServices.Foundation.Models.Services.ConfigureServices(services);
            services.AddSingleton<ApplicationHostViewModel>();

            Factory.ViewModelLocator.ConfigureServices(services);
            Feature.Workcenters.ViewModelLocator.ConfigureServices(services);
        }
    }
}
