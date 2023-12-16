using System;
using Microsoft.Extensions.DependencyInjection;

namespace ExecutionProcessor
{
    public interface IExecutionProcessor
    {
        void Validate(Request request);
        void Process(Request request);
        void Publish(Request request);
    }

    public class MFExecutor : IExecutionProcessor
    {
        public void Validate(Request request)
        {
            Console.WriteLine("Validating MFExecutor request...");
        }

        public void Process(Request request)
        {
            Console.WriteLine("Processing MFExecutor request...");
        }

        public void Publish(Request request)
        {
            Console.WriteLine("Publishing MFExecutor request...");
        }
    }

    public class EquityExecutor : IExecutionProcessor
    {
        public void Validate(Request request)
        {
            Console.WriteLine("Validating EquityExecutor request...");
        }

        public void Process(Request request)
        {
            Console.WriteLine("Processing EquityExecutor request...");
        }

        public void Publish(Request request)
        {
            Console.WriteLine("Publishing EquityExecutor request...");
        }
    }

    public class Request
    {
        public string Type { get; set; }
        public string Data { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var serviceProvider = new ServiceCollection()
                .AddKeyedSingleton<IExecutionProcessor, EquityExecutor>("Equity")
                .AddKeyedSingleton<IExecutionProcessor, MFExecutor>("MF")
                .BuildServiceProvider();

            var request = new Request { Type = "MF", Data = "Price data" };
            var executionProcessor = serviceProvider.GetKeyedService<IExecutionProcessor>(request.Type);
            executionProcessor.Validate(request);
            executionProcessor.Process(request);
            executionProcessor.Publish(request);

            request = new Request { Type = "Equity", Data = "Confirmation data" };
            executionProcessor = serviceProvider.GetKeyedService<IExecutionProcessor>(request.Type);
            executionProcessor.Validate(request);
            executionProcessor.Process(request);
            executionProcessor.Publish(request);
        }
    }
}
