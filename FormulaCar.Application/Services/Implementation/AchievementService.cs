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
    public class AchievementService : IAchievementService
    {
        private readonly IMapper _mapper;
        private readonly AppDbContext _context;
        private readonly IAchievementRepository _achievementRepository;
        public AchievementService(IMapper mapper, IAchievementRepository achievementRepository, AppDbContext context)
        {
            _achievementRepository = achievementRepository;
            _mapper = mapper;
            _context = context;
        }

        public async Task<AchievementResponeDto> CreateDriverAchievement(AchievementRequestDto achievement)
        {
            var result = _mapper.Map<Achievement>(achievement);
            await _achievementRepository.Add(result);
            await _context.SaveChangesAsync();
            var response = _mapper.Map<AchievementResponeDto>(result);
            return response;
        }

        public async Task<AchievementResponeDto> GetDriverAchievement(Guid DriverId)
        {
            var driverAchievement = await _achievementRepository.GetDriverAchievement(DriverId);
            var result = _mapper.Map<AchievementResponeDto>(driverAchievement);
            return result;
        }

        public async Task<bool> UpdateAchievement(UpdateAchievementRequestDto update)
        {
            var result = _mapper.Map<Achievement>(update);
            await _achievementRepository.Update(result);
            await _context.SaveChangesAsync();
            return true;
        }
    }
}