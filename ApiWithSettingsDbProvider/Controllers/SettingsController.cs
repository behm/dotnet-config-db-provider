using AppWithDbSettingsProvider.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppWithDbSettingsProvider.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SettingsController : ControllerBase
    {
        private readonly ApiSettings _apiSettings;

        public SettingsController(ApiSettings apiSettings)
        {
            _apiSettings = apiSettings;
        }

        public ActionResult Index()
        {
            return Ok(_apiSettings);
        }
    }
}