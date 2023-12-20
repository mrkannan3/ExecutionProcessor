using ExecutionAPI.Behaviors.OrderProcessor;
using ExecutionAPI.Behaviors.OrderRetriever;
using ExecutionAPI.Behaviors.Publisher;
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
            services.AddScoped<ExecutionProcessor>();
            /*services.AddKeyedScoped<IOrderRetriever, EquityOrderRetriever>("Equity");
            services.AddKeyedScoped<IOrderRetriever, MFOrderRetriever>("MF");
            services.AddKeyedScoped<IProcessor, EquityProcessor>("Equity");
            services.AddKeyedScoped<IProcessor, MFProcessor>("MF");
            services.AddKeyedScoped<IPublisher, EventPublisher>("Event");
            services.AddKeyedScoped<IPublisher, LogPublisher>("Log");*/
            services.AddScoped<IOrderRetriever, EquityOrderRetriever>();
            services.AddScoped<IOrderRetriever, MFOrderRetriever>();
            services.AddScoped<IProcessor, EquityProcessor>();
            services.AddScoped<IProcessor, MFProcessor>();
            services.AddScoped<IPublisher, EventPublisher>();
            services.AddScoped<IPublisher, LogPublisher>();
            //services.AddSingleton(Channel.CreateUnbounded<OrderRequest>());
            services.AddSingleton(Channel.CreateBounded<OrderRequest>(1));
            services.AddHostedService<ExecutionDispatcher>();
            services.AddScoped<Factory>();
        }
    }
}
