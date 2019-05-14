﻿using CarShared.Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarShared.Shared.DTO
{
    public class CityDTO
    {
        public int CityId { get; set; }
        public string Name { get; set; }
        public Country Country { get; set; }
    }
}
