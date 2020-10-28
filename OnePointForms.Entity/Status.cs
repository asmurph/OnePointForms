using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
    public class Status
    {
        [Key]
        public int Status1 { get; set; }
        public string Choice { get; set; }

    }
}
