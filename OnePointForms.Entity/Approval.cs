using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
     public class Approval
    {
        [Key]
        public int ApprovalID { get; set; }
        public string Status { get; set; }
    }
}
