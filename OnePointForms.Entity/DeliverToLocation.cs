﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
     public class DeliverToLocation
    {
        [Key]
        public string DeliverToLocationID { get; set; }
        public string Choice { get; set; }

    }
}
