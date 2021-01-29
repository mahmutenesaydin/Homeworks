using System;
using System.Collections.Generic;

namespace ServiceCRMDB.Models
{
    public partial class RulingParty
    {
        public int PartyID { get; set; }
        public string Party { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> TownID { get; set; }
        public virtual Province Province { get; set; }
        public virtual Town Town { get; set; }
    }
}
