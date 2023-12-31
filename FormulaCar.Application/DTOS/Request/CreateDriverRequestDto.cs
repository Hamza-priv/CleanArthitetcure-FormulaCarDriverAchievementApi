﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaCar.Application.DTOS.Request
{
    public class CreateDriverRequestDto
    {
        public string firstName { get; set; } = string.Empty;
        public string lastName { get; set; } = string.Empty;
        public DateTime dateofbirth { get; set; }
        public int driverNumber { get; set; }
    }
}
