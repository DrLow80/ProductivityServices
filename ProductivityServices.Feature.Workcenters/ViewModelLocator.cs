using Microsoft.Extensions.DependencyInjection;
using ProductivityServices.DependencyInjection;

namespace ProductivityServices.Feature.Workcenters
{
    public class ViewModelLocator
    {
        public static WorkcentersHostViewModel WorkcentersHostViewModel => DependencyInjectionContext.Get<WorkcentersHostViewModel>();

        public static ListViewModel ListViewModel => DependencyInjectionContext.Get<ListViewModel>();

        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<WorkcentersHostViewModel>();
            services.AddSingleton<ListViewModel>();
        }
    }
}