using Microsoft.Extensions.DependencyInjection;

namespace ProductivityServices.Foundation.Models
{
    public class Services
    {
        public static void ConfigureServices(ServiceCollection services)
        {
            services.AddSingleton<IModelsService, ModelsService>();
        }
    }
}