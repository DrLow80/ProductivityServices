using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace ProductivityServices.DependencyInjection
{
    public class DependencyInjectionContext
    {
        private static ServiceProvider _serviceProvider;

        public static void Update(ServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public static T Get<T>()
        {
            return _serviceProvider.GetService<T>();
        }
    }
}
