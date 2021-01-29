using System;
using System.Collections.Generic;

namespace IO___CodeFirst_EntFram.Models
{
    public partial class Area
    {
        public int AreaID { get; set; }
        public string Area1 { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> TownID { get; set; }
        public virtual Province Province { get; set; }
        public virtual Town Town { get; set; }
    }
}
