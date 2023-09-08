using FormulaCar.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FormulaCar.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BaseController : Controller
    {
        protected readonly IDriverService _driverServices;
        protected readonly IAchievementService _achievementService;

        public BaseController(IDriverService driverServices, IAchievementService achievementService)
        {
            _driverServices = driverServices;
            _achievementService = achievementService;
        }
    }
}
