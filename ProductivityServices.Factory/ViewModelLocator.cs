using Microsoft.Extensions.DependencyInjection;
using ProductivityServices.DependencyInjection;
using ProductivityServices.Factory.Factory;
using System;

namespace ProductivityServices.Factory
{
    public class ViewModelLocator
    {
        public static FactoryHostViewModel FactoryHostViewModel=> DependencyInjectionContext.Get<FactoryHostViewModel>();

        public static FactoryViewModel FactoryViewModel=> DependencyInjectionContext.Get<FactoryViewModel>();

        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<FactoryHostViewModel>();
            services.AddSingleton<FactoryViewModel>();
            services.AddSingleton<IFactoryService, FactoryService>();
            services.AddSingleton<IFileSystemService, FileSystemService>();
        }
    }
}
