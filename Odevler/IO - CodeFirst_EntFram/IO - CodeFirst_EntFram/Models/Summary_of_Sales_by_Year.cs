using System;
using System.Collections.Generic;

namespace IO___CodeFirst_EntFram.Models
{
    public partial class Summary_of_Sales_by_Year
    {
        public Nullable<System.DateTime> ShippedDate { get; set; }
        public int OrderID { get; set; }
        public Nullable<decimal> Subtotal { get; set; }
    }
}
