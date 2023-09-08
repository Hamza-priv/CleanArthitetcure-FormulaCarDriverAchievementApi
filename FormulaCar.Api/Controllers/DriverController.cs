using FormulaCar.Application.DTOS.Request;
using FormulaCar.Application.DTOS.Response;
using FormulaCar.Application.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace FormulaCar.Api.Controllers
{
    public class DriverController : BaseController
    {
        private readonly IDriverService _driverServices;

        public DriverController(IDriverService driverServices, IAchievementService achievementService)
        : base(driverServices, achievementService)
        {
            _driverServices = driverServices;
        }

        [HttpGet]
        [Route("getDrivers")]
        public async Task<ActionResult<DriverResponseDto>> GetDrivers()
        {
            return Ok(await _driverServices.GetAllDrivers());
        }

        [HttpGet]
        [Route("getDriver/{driverId:Guid}")]
        public async Task<ActionResult<DriverResponseDto>> GetDriver(Guid driverId)
        {
            return Ok(await _driverServices.GetDriverById(driverId));
        }

        [HttpPost]
        [Route("addDriver")]
        public async Task<ActionResult> AddDriver([FromBody] CreateDriverRequestDto newDriver)
        {
            return Ok(await _driverServices.CreateDriver(newDriver));
        }

        [HttpPut]
        [Route("updateDriver")]
        public async Task<ActionResult> UpdateDriver([FromBody] UpdateDriverRequestDTO updateDriver)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("Error in Data");
            }
            return Ok(await _driverServices.UpdateDriver(updateDriver));
        }

        [HttpDelete]
        [Route("deleteDriver/{driverId:Guid}")]
        public async Task<ActionResult> DeleteDriver(Guid driverId)
        {
            var driver = await _driverServices.DeleteDriver(driverId);
            if (driver == false)
            {
                return NotFound("No Driver to be found");
            }
            return Ok("Updated");
        }
    }
}
