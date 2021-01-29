using System;
using System.Collections.Generic;

namespace IO___CodeFirst_EntFram.Models
{
    public partial class Region
    {
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public virtual Province Province { get; set; }
    }
}
