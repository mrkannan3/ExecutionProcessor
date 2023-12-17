using BenchmarkDotNet.Attributes;
using ExecutionAPI.Model;
using ExecutionAPI.Processor;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExecutionConsole
{
    [MemoryDiagnoser]
    public class BenchmarkExecution
    {
        Factory _factory;
        [GlobalSetup] public void Setup()
        {
            var host = Host.CreateDefaultBuilder().ConfigureServices(services => {
                services.AddKeyedScoped<IExecutionProcessor, EquityProcessor>("Equity");
                services.AddKeyedScoped<IExecutionProcessor, MFProcessor>("MF");
                services.AddSingleton<Factory>();
                //services.AddScoped<BenchmarkExecution>();
            }).Build();
            _factory = host.Services.GetRequiredService<Factory>();
        }
        [Benchmark]
        public void Execute()
        {
            List<OrderRequest> reqs = new List<OrderRequest>();
            reqs.Add(new OrderRequest() { Type="Equity", OrderName=""});
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "Equity", OrderName = "" });
            reqs.Add(new OrderRequest() { Type = "MF", OrderName = "" });
            reqs.ForEach(Request =>
            {
                var processor = _factory.GetRequiredService<IExecutionProcessor>(Request.Type);
                processor?.Process(Request);
            });
        }
    }
}
