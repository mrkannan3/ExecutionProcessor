using ExecutionAPI.ChannelDispatcher;
using ExecutionAPI.Model;
using ExecutionAPI.Processor;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace ExecutionAPI
{
    public static class Registry
    {
        public static void AddExecutionDependnecies(this IServiceCollection services)
        {
            services.AddKeyedScoped<IExecutionProcessor, EquityProcessor>("Equity");
            services.AddKeyedScoped<IExecutionProcessor, MFProcessor>("MF");
            services.AddSingleton(Channel.CreateUnbounded<OrderRequest>());
            services.AddHostedService<ExecutionDispatcher>();
            services.AddScoped<Factory>();
        }
    }
}
