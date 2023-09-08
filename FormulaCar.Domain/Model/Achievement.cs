using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulaCar.Domain.Model
{
    public class Achievement : Generic
    {
        public int racewins { get; set; }
        public int fastestLap { get; set; }
        public int champions { get; set; }
        public int poleposition { get; set; }
        public Guid DriverId { get; set; }
        public virtual Driver? driver { get; set; }
    }
}