using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
    public class NaturalExpense
    {
        [Key]
        public string NEID { get; set; }
        public string Choice { get; set; }
    }
}
