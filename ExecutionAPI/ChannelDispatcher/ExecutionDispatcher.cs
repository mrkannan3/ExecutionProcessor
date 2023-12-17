
using ExecutionAPI.Model;
using ExecutionAPI.Processor;
using System.Threading.Channels;

namespace ExecutionAPI.ChannelDispatcher
{
    public class ExecutionDispatcher : BackgroundService
    {
        private readonly Channel<OrderRequest> _channel;
        private readonly IServiceProvider _provider;
        //private readonly Factory _factory;
        public ExecutionDispatcher(Channel<OrderRequest> channel, IServiceProvider provider)
        {
            _channel = channel;
            _provider = provider;
        }
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            using (var scope = _provider.CreateScope())
            {
                while (!_channel.Reader.Completion.IsCompleted)
                {
                    var msg = await _channel.Reader.ReadAsync();
                    var processor = scope.ServiceProvider.GetKeyedService<IExecutionProcessor>(msg.Type);
                    processor.Process(msg);
                }
            }
            
        }
    }
}
