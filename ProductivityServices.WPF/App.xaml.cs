using Microsoft.Extensions.DependencyInjection;
using ProductivityServices.DependencyInjection;
using ProductivityServices.Factory;
using ProductivityServices.Factory.Factory;
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
            DependencyInjectionContext.ServiceProvider = services.BuildServiceProvider();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<ApplicationHostViewModel>();
            services.AddSingleton<FactoryHostViewModel>();
            services.AddSingleton<FactoryViewModel>();
            services.AddSingleton<IFileSystemService, FileSystemService>();
        }
    }
}
