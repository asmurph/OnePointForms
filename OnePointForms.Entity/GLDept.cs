using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
    public class GLDept
    {
        [Key]
        public string GLDeptId { get; set; }
        public string Choice { get; set; }
    }
}
