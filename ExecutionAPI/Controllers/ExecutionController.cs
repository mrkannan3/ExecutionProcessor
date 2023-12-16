using ExecutionAPI.Model;
using ExecutionAPI.Processor;
using Microsoft.AspNetCore.Mvc;

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
        public IActionResult Process([FromBody] OrderRequest Request)
        {
            var processor  = _factory.GetRequiredService<IExecutionProcessor>(Request.Type);
            processor.Process(Request);
            return Ok(Request);
        }
    }
}
