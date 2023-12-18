using BenchmarkDotNet.Attributes;
using ExecutionAPI.Behaviors.OrderProcessor;
using ExecutionAPI.Behaviors.Publisher;
using ExecutionAPI.ChannelDispatcher;
using ExecutionAPI.Model;
using ExecutionAPI.Processor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System.Threading.Channels;

namespace ExecutionConsole
{
    [MemoryDiagnoser]
    public class BenchmarkExecution
    {
        Factory _factory;
        [GlobalSetup] public void Setup()
        {
            var host = Host.CreateDefaultBuilder().ConfigureServices(services => {
                services.AddScoped<ExecutionProcessor>();
                services.AddKeyedScoped<IProcessor, EquityProcessor>("Equity");
                services.AddKeyedScoped<IProcessor, MFProcessor>("MF");
                services.AddKeyedScoped<IPublisher, EventPublisher>("Event");
                services.AddKeyedScoped<IPublisher, LogPublisher>("Log");
                //services.AddSingleton(Channel.CreateUnbounded<OrderRequest>());
                services.AddSingleton(Channel.CreateBounded<OrderRequest>(1));
                services.AddHostedService<ExecutionDispatcher>();
                services.AddScoped<Factory>();
            }).Build();
            _factory = host.Services.GetRequiredService<Factory>();
        }
        [Benchmark]
        public void Execute()
        {
            List<OrderRequest> reqs = new List<OrderRequest>();
            reqs.Add(new OrderRequest() { Type="Equity", PublishType="Log", OrderName=""});
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.Add(new OrderRequest() { Type="Equity",PublishType="Log",OrderName = "" });
            reqs.Add(new OrderRequest() { Type="MF",PublishType="Event", OrderName = "" });
            reqs.ForEach(Request =>
            {
                var processor = _factory.GetRequiredService<ExecutionProcessor>();
                processor?.ProcessOrder(Request);
            });
        }
    }
}
