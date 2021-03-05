using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WebhookController : ControllerBase
    {
        private readonly ILogger<WebhookController> _logger;

        public WebhookController(ILogger<WebhookController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public ActionResult Post([FromBody] HookRequest hookRequest)
        {
            _logger.LogInformation(hookRequest.text);

            return Accepted();
        }
    }

    public record HookRequest(string text);
}
