using Microsoft.Extensions.DependencyInjection;
using System.Xml.Linq;

namespace ExecutionAPI.Processor
{
    public class Factory
    {
        private readonly IServiceProvider _serviceProvider;
        public Factory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        /*public T GetRequiredService<T>(string? name = null)
        {
            if (!string.IsNullOrEmpty(name))
                return _serviceProvider.GetKeyedService<T>(name);
            else
                return _serviceProvider.GetService<T>();
        }*/
        public TService GetRequiredService<TService>(string name = null) where TService : class
        {
            if (name == null)
            {
                return _serviceProvider.GetService<TService>();
            }
            // Get the interface type
            var interfaceType = typeof(TService);

            // Determine the corresponding implementation type based on the request type
            var implementationType = GetImplementationType(interfaceType, name);

            // Resolve the service and cast it to the specified interface type
            var service = _serviceProvider.GetServices<TService>();
            foreach (var item in service)
            {
                if (item.GetType()  == implementationType)
                {
                    return item;
                }
            }

            throw new InvalidOperationException($"Failed to resolve service for interface {interfaceType}.");
            
        }

        private Type GetImplementationType(Type interfaceType, string requestType)
        {
            var implementationTypeName = $"{requestType}{interfaceType.Name.Substring(1)}";

            var implementationType = interfaceType.Assembly.GetTypes()
                .FirstOrDefault(type => type.Name == implementationTypeName);

            if (implementationType == null)
            {
                throw new NotSupportedException($"Unsupported request type: {requestType}");
            }

            return implementationType;
        }

    }
}
