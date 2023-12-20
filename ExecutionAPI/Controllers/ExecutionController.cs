using ExecutionAPI.Model;
using ExecutionAPI.Processor;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Channels;

namespace ExecutionAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExecutionController : Controller
    {
        Factory _factory;
        public ExecutionController(Factory factory) {
            _factory = factory;
        }

        [HttpPost("Process")]
        public IActionResult Process([FromBody] List<OrderRequest> Requests)
        {
            var orders= new List<Order>();
            Requests.ForEach(Request =>
            {
                var processor = _factory.GetRequiredService<ExecutionProcessor>();
                orders.AddRange(processor.ProcessOrder(Request));
            });
            return Ok(orders);
        }
        [HttpPost("ProcessParallel")]
        public IActionResult ProcessParallel([FromBody] List<OrderRequest> Requests , [FromServices] Channel<OrderRequest> channel)
        {
            Requests.ForEach(Request =>
            {
                channel.Writer.WriteAsync(Request);
            });
            return Ok(Requests);
        }
    }
}
