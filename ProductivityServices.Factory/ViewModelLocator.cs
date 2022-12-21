using Microsoft.Extensions.DependencyInjection;
using ProductivityServices.DependencyInjection;

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
    }
}
