using System;
using System.Collections.Generic;

namespace ServiceCRMDB.Models
{
    public partial class Village
    {
        public int VillageID { get; set; }
        public string VillageName { get; set; }
        public Nullable<int> TownID { get; set; }
        public virtual Town Town { get; set; }
    }
}
