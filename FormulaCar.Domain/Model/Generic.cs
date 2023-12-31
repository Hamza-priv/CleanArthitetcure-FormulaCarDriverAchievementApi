using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FormulaCar.Domain.Model
{
    public class Generic
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime createdDate { get; set; } = DateTime.UtcNow;
        public DateTime updatedDate { get; set; } = DateTime.UtcNow;
        public int status { get; set; }
    }
}