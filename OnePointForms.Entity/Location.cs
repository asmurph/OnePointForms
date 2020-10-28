using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
    public class Location
    {
        [Key]
        public int LocationId { get; set; }
        public string Choice { get; set; }
    }
}
