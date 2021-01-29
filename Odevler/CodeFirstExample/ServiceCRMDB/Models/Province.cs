using System;
using System.Collections.Generic;

namespace ServiceCRMDB.Models
{
    public partial class Province
    {
        public Province()
        {
            this.Areas = new List<Area>();
            this.PlacesToVisits = new List<PlacesToVisit>();
            this.Populations = new List<Population>();
            this.Regions = new List<Region>();
            this.RulingParties = new List<RulingParty>();
            this.Towns = new List<Town>();
            this.TransportationServices = new List<TransportationService>();
            this.WhatFamous = new List<WhatFamou>();
        }

        public int ProvinceID { get; set; }
        public string ProvinceName { get; set; }
        public Nullable<int> PlateCode { get; set; }
        public virtual ICollection<Area> Areas { get; set; }
        public virtual ICollection<PlacesToVisit> PlacesToVisits { get; set; }
        public virtual ICollection<Population> Populations { get; set; }
        public virtual ICollection<Region> Regions { get; set; }
        public virtual ICollection<RulingParty> RulingParties { get; set; }
        public virtual ICollection<Town> Towns { get; set; }
        public virtual ICollection<TransportationService> TransportationServices { get; set; }
        public virtual ICollection<WhatFamou> WhatFamous { get; set; }
    }
}
