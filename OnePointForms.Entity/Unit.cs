﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
    public class Unit
    {
        [Key]

        public string UnitId { get; set; }
        public string Choice { get; set; }
    }
}
