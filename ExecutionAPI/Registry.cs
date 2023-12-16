using ExecutionAPI.Processor;
using System.Runtime.CompilerServices;

namespace ExecutionAPI
{
    public static class Registry
    {
        public static void AddExecutionDependnecies(this IServiceCollection services)
        {
            services.AddKeyedScoped<IExecutionProcessor, EquityProcessor>("Equity");
            services.AddKeyedScoped<IExecutionProcessor, MFProcessor>("MF");
            services.AddScoped<Factory>();
        }
    }
}
