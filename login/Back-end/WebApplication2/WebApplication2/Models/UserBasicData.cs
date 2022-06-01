﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models
{
    public class UserBasicData
    {
        [Required]
        public string UserEmail { get; set; }

        [Required]
        public string UserKeyword { get; set; }
    }
}
