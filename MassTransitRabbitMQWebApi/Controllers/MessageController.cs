using MassTransit;
using MassTransitRabbitMQWebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MassTransitRabbitMQWebApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MessageController : ControllerBase
    {
        private readonly IPublishEndpoint _publishEndpoint;

        public MessageController(IPublishEndpoint publishEndpoint)
        {
            _publishEndpoint = publishEndpoint;
        }




        [HttpPost]
        public async Task<IActionResult> Post(string text)
        {
            var message = new ExampleMessage();
            message.Text = text;    

            await _publishEndpoint.Publish(message);
            return Ok("Message sent");
        }
    }
}
