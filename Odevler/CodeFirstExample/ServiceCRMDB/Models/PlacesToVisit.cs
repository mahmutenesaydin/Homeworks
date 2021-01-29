using System;
using System.Collections.Generic;

namespace ServiceCRMDB.Models
{
    public partial class PlacesToVisit
    {
        public int PlacesToVisitID { get; set; }
        public string PlacesToVisit1 { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public virtual Province Province { get; set; }
    }
}
