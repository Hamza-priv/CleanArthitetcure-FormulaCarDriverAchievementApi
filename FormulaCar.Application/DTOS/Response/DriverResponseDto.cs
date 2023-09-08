using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaCar.Application.DTOS.Response
{
    public class DriverResponseDto
    {
        Guid DriverId { get; set; }
        public string FullName { get; set; } = string.Empty;
        public DateTime dateofbirth { get; set; }
        public int driverNumber { get; set; }
    }
}
