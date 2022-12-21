using Microsoft.Extensions.DependencyInjection;
using ProductivityServices.DependencyInjection;

namespace ProductivityServices.WPF.Features
{
    public class ViewModelLocator
    {
        public static ApplicationHostViewModel ApplicationViewModel
        {
            get
            {
                return DependencyInjectionContext.ServiceProvider.GetService<ApplicationHostViewModel>();
            }
        }
    }
}
