using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaCar.Application.DTOS.Request;
using FormulaCar.Application.DTOS.Response;

namespace FormulaCar.Application.Services.Interfaces
{
    public interface IAchievementService
    {
        Task<AchievementResponeDto> GetDriverAchievement(Guid DriverId);
        Task<AchievementResponeDto> CreateDriverAchievement(AchievementRequestDto achievement);
        Task<bool> UpdateAchievement(UpdateAchievementRequestDto update);
    }
}