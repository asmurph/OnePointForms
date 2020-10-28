using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace OnePointForms.Entity
{
   public class BuyersName
    {
        [Key]
        public int BuyerNameID { get; set; }
        public string BuyerName { get; set; }
    }
}
