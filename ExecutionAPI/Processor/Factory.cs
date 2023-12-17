using Microsoft.Extensions.DependencyInjection;

namespace ExecutionAPI.Processor
{
    public class Factory
    {
        private readonly IServiceProvider _serviceProvider;
        public Factory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }
        public T GetRequiredService<T>(string? name = null)
        {
            if (!string.IsNullOrEmpty(name))
                return _serviceProvider.GetKeyedService<T>(name);
            else
                return _serviceProvider.GetService<T>();
        }
    }
}
