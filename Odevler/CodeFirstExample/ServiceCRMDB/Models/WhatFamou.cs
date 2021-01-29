using System;
using System.Collections.Generic;

namespace ServiceCRMDB.Models
{
    public partial class WhatFamou
    {
        public int WhatFamousID { get; set; }
        public string WhatFamous { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public virtual Province Province { get; set; }
    }
}
