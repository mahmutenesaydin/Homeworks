using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Model
{
    [Table("Town")]
    public class Town
    {
        public Town()
        {
            this.Villages = new List<Village>();
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int TownID { get; set; }
        public string TownName { get; set; }
        public byte[] Images { get; set; }
        public Nullable<int> ProvinceID { get; set; }
        public Nullable<int> PlaceToVisitID { get; set; }
        public Nullable<int> WhatFamousID { get; set; }
        public Nullable<int> PopulationID { get; set; }
        public Nullable<int> TransportationServiceID { get; set; }
        public Nullable<int> PartyID { get; set; }

        [ForeignKey("PlacesToVisitID")]
        public PlacesToVisit PlacesToVisit { get; set; }
        [ForeignKey("ProvinceID")]
        public Province ProvinceName { get; set; }
        [ForeignKey("PartyID")]
        public RulingParty Party { get; set; }
        [ForeignKey("TransportationServiceID")]
        public TransportationService TransportationServicee { get; set; }
        [ForeignKey("WhatFamousID")]
        public WhatFamous WhatFamouss { get; set; }
        
        public List<Village> Villages { get; set; }
    }
}
