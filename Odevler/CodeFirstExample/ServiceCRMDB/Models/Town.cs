using System;
using System.Collections.Generic;

namespace ServiceCRMDB.Models
{
    public partial class Town
    {
        public Town()
        {
            this.Areas = new List<Area>();
            this.Populations = new List<Population>();
            this.RulingParties = new List<RulingParty>();
            this.TransportationServices = new List<TransportationService>();
            this.Villages = new List<Village>();
        }

        public int TownID { get; set; }
        public string TownName { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<Population> Populations { get; set; }
        public virtual Province Province { get; set; }
        public virtual ICollection<RulingParty> RulingParties { get; set; }
        public virtual ICollection<TransportationService> TransportationServices { get; set; }
        public virtual ICollection<Village> Villages { get; set; }
    }
}
