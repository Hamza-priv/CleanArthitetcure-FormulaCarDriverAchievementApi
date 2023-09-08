using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaCar.Application.DTOS.Request;
using FormulaCar.Application.DTOS.Response;
using FormulaCar.Domain.Model;

namespace FormulaCar.Application.Services.Interfaces
{
    public interface IDriverService
    {
        Task<IEnumerable<Driver>> GetAllDrivers();
        Task<DriverResponseDto> GetDriverById(Guid Id);
        Task<DriverResponseDto> CreateDriver(CreateDriverRequestDto newDriver);
        Task<Driver> UpdateDriver(UpdateDriverRequestDTO updateDriver);
        Task<bool> DeleteDriver(Guid Id);
    }
}