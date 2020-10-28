using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
   public  class AcceptStatus
    {
        [Key]
        public int AcceptedID { get; set; }
        public string Status { get; set; }

    }
}
