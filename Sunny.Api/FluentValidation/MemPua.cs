﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Sunny.Api.FluentValidation2
{
    public class MemPua
    {
        [Required]
        public string Name { get; set; }
    }
}
