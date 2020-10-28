using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
    public class NaturalExpense
    {
        [Key]
        public int NEID { get; set; }
        public string Choice { get; set; }
    }
}
