using Microsoft.Extensions.DependencyInjection;
using ProductivityServices.DependencyInjection;
using ProductivityServices.Factory.Factory;

namespace ProductivityServices.Factory
{
    public class ViewModelLocator
    {
        public static FactoryHostViewModel FactoryHostViewModel
        {
            get
            {
                return DependencyInjectionContext.ServiceProvider.GetService<FactoryHostViewModel>();
            }
        }

        public static FactoryViewModel FactoryViewModel
        {
            get
            {
                return DependencyInjectionContext.ServiceProvider.GetService<FactoryViewModel>();
            }
        }
    }
}
