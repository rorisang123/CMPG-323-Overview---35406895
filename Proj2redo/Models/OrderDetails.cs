using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Proj2redo.Models
{
    public class OrderDetails
    {
        public int OrderDetailsID { get; set; }
        [Required]
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Discount { get; set; }
    }
}