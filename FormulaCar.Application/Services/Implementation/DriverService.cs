using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using FormulaCar.Application.DTOS.Request;
using FormulaCar.Application.DTOS.Response;
using FormulaCar.Application.Services.Interfaces;
using FormulaCar.Domain.IRepository;
using FormulaCar.Domain.Model;
using FormulaCar.Infrastructure.DataBase;

namespace FormulaCar.Application.Services.Implementation
{
    public class DriverService : IDriverService
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;
        private readonly IDriverRepository _driverRepository;
        public DriverService(IMapper mapper, IDriverRepository driverRepository, AppDbContext context)
        {
            _driverRepository = driverRepository;
            _mapper = mapper;
            _context = context;
        }
        public async Task<DriverResponseDto> CreateDriver(CreateDriverRequestDto newDriver)
        {
            var result = _mapper.Map<Driver>(newDriver);
            await _driverRepository.Add(result);
            await _context.SaveChangesAsync();
            var response = _mapper.Map<DriverResponseDto>(result);
            return response;
        }

        public async Task<bool> DeleteDriver(Guid Id)
        {
            var driver = await _driverRepository.GetbyId(Id);
            if (driver is not null)
            {
                await _driverRepository.Delete(Id);
                await _context.SaveChangesAsync();
                return true;
            }
            return false;
        }

        public async Task<IEnumerable<Driver>> GetAllDrivers()
        {
            var drivers = await _driverRepository.All();
            return drivers;
        }

        public async Task<DriverResponseDto> GetDriverById(Guid Id)
        {
            var driver = await _driverRepository.GetbyId(Id);
            var result = _mapper.Map<DriverResponseDto>(driver);
            return result;
        }

        public async Task<Driver> UpdateDriver(UpdateDriverRequestDTO updateDriver)
        {
            var result = _mapper.Map<Driver>(updateDriver);
            await _driverRepository.Update(result);
            await _context.SaveChangesAsync();
            
            return result;
        }
    }
}