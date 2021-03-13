using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace MailService.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        private readonly IEmailService _ies;

        public WeatherForecastController(IEmailService ies)
        {
            _ies = ies;
        }

        [HttpGet]
        public async Task<IActionResult> SendMessage()
        {
            await _ies.SendEmailAsync("t.mukhutdinov.job@gmail.com", "Тема письма", "Какое-то сообщение");
            return null;
        }

    }
}
