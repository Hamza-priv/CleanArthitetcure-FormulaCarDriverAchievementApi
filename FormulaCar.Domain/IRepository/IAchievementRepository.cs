using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormulaCar.Domain.Model;

namespace FormulaCar.Domain.IRepository
{
    public interface IAchievementRepository : IGenericRepository<Achievement>
    {
        Task<Achievement?> GetDriverAchievement(Guid driverID);
    }
}